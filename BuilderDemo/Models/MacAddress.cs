﻿using BuilderDemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDemo.Models
{
    public class MacAddress : IUserIdentity
    {
        public string RawAddress { get; set; }
    }
}
