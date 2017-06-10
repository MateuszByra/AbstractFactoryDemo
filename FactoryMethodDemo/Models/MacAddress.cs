using FactoryMethodDemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDemo.Models
{
    public class MacAddress : IUserIdentity
    {
        public string RawAddress { get; set; }
    }
}
