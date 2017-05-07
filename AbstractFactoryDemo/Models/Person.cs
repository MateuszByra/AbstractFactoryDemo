using AbstractFactoryDemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDemo.Models
{
    public class Person : IUser
    {
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
