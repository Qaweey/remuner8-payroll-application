﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Dtos;
using API.Models;

namespace API.Repositories
{
    public interface IPayslipRepository
    {
      Task< PayslipDto> GetPayslipByIdAsync(string id);
    }
}