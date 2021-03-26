﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API.Dtos;
using API.Models;
using AutoMapper;
using API.Repositories;
using API.Authentication;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentsController : ControllerBase
    {
        private readonly IDepartmentRepository _departmentsRepo;
        private readonly IMapper _mapper;

        public DepartmentsController(IDepartmentRepository department, IMapper mapper)
        {
            _departmentsRepo = department;
            _mapper = mapper;
        }

        private Task<bool> DepartmentNameExists(string name)
        {
            return _departmentsRepo.DepartmentExists(name);
        }

        // GET: api/Department
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DepartmentDto>>> GetDepartments()
        {
            var departmentsFromRepo = await _departmentsRepo.GetAllDepartmentsAsync();
            var departments = _mapper.Map<IEnumerable<DepartmentDto>>(departmentsFromRepo);
            return Ok(departments);
        }

        // GET: api/Department/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DepartmentDto>> GetDepartment(int id)
        {
            var department = await _departmentsRepo.GetDepartmentByIdAsync(id);

            if (department is not null) return Ok(_mapper.Map<DepartmentDto>(department));

            return NotFound(new Response { Status = "Error", Message = $"The department with ID: {id} does not exist." });
        }

        // POST: api/Department
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<DepartmentDto>> PostDepartment(DepartmentCreateDto departmentCreateDto)
        {
            if (await DepartmentNameExists(departmentCreateDto.DepartmentName)) return StatusCode(StatusCodes.Status400BadRequest, new Response { Status = "Error", Message = "A department with that name already exists" });

            var department = _mapper.Map<Departments>(departmentCreateDto);
            await _departmentsRepo.CreateDepartmentAsync(department);
            await _departmentsRepo.SaveChangesAsync();

            var departmentReadDto = _mapper.Map<DepartmentDto>(department);

            return CreatedAtAction("GetDepartment", new { id = departmentReadDto.DepartmentId }, departmentReadDto);
        }

        //  PUT: api/Department/5
        //  To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<ActionResult> PutDepartment(int id, DepartmentDto departmentDto)
        {
            if (id != departmentDto.DepartmentId) return BadRequest();
            var departmentFromRepo = await _departmentsRepo.GetDepartmentByIdAsync(id);

            try
            {
                _mapper.Map(departmentDto, departmentFromRepo);
                await _departmentsRepo.UpdateDepartment(departmentFromRepo);
                await _departmentsRepo.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (departmentFromRepo is null) return NotFound();
                else throw;
            }

            return NoContent();
        }

        // DELETE: api/Department/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteDepartment(int id)
        {
            var departmentFromRepo = await _departmentsRepo.GetDepartmentByIdAsync(id);
            if (departmentFromRepo is null) return NotFound(new Response { Status = "Error", Message = $"The department with ID: {id} does not exist." });

            await _departmentsRepo.DeleteDepartmentAsync(departmentFromRepo);
            await _departmentsRepo.SaveChangesAsync();

            return NoContent();
        }
    }
}