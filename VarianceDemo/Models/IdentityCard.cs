﻿using VarianceDemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarianceDemo.Models
{
    public class IdentityCard : IUserIdentity
    {
        public string SSN { get; set; } // social security number
    }
}
