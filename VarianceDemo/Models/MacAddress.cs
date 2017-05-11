using VarianceDemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarianceDemo.Models
{
    public class MacAddress : IUserIdentity
    {
        public string RawAddress { get; set; }
    }
}
