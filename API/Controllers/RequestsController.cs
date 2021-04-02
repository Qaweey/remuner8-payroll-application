﻿using API.Dtos;
using API.Models;
using API.Repositories;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RequestsController : ControllerBase
    {
        private readonly IRequestsRepository requestsRepository;
        private readonly IMapper mapper;

        public RequestsController(IRequestsRepository requestsRepository, IMapper mapper)
        {
            this.requestsRepository = requestsRepository;
            this.mapper = mapper;
        }

        // GET: api/<RequestsController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RequestReadDto>>> GetAllRequestsAsync()
        {
            var request = await requestsRepository.GetAllAsync();
            var mappedmodel = mapper.Map<IEnumerable<RequestReadDto>>(request);
            return Ok(mappedmodel);
        }

        // GET api/<RequestsController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RequestReadDto>> GetRequestById(int id)
        {
            var request = await requestsRepository.GetRequestAsync(id);
            return Ok(request);
        }

        // POST api/<RequestsController>
        [HttpPost]
        public async Task<ActionResult> PostRequest(RequestCreateDto requestCreate)
        {
            var mappedmodel = mapper.Map<Request>(requestCreate);
            await requestsRepository.CreateRequestAsync(mappedmodel);
            await requestsRepository.SaveAsync();
            return StatusCode(StatusCodes.Status201Created);

        }

        // PUT api/<RequestsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        
        }

        // DELETE api/<RequestsController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var request = await requestsRepository.GetRequestAsync(id);
            if (request != null)
            {
                await requestsRepository.RemoveRequestAsync(id);
                await requestsRepository.SaveAsync();
                return Ok();
            }
            return NotFound();

            
        }
    }
}