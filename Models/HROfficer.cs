﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeesSalaries.Models
{
    public class HROfficer : Employee, IManaged<Manager>
    {
        public Manager Manager { get; set; }
        
    }
}
