﻿using SpecificationDemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecificationDemo.Models
{
    public class MacAddress : IUserIdentity
    {
        public string RawAddress { get; set; }
    }
}
