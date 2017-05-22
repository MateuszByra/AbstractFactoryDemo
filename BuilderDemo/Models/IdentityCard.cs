﻿using BuilderDemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDemo.Models
{
    public class IdentityCard : IUserIdentity
    {
        //public string SSN { get; set; } // social security number
        public string SSN => "social_security_number";
    }
}
