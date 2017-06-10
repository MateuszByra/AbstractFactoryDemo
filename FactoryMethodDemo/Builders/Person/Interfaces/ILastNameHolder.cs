﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDemo.Builders.Person.Interfaces
{
    public interface ILastNameHolder
    {
        IPrimaryContactHolder WithLastName(string surname);
    }
}
