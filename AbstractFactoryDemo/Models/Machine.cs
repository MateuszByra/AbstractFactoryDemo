using AbstractFactoryDemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDemo.Models
{
    public class Machine : IUser
    {
        public Producer Producer { get; set; }
        public string Model { get; set; }

        public void SetIdentity(IUserIdentity identity)
        {
            throw new NotImplementedException();
        }
    }
}
