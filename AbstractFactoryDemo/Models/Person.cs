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
        private string name { get; set; }
        private string surname { get; set; }

        public Person()
        {

        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("First name must be non-empty.");
                this.name = value;
            }
        }

        public string Surname
        {
            get
            {
                return this.surname;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Last name must be non-empty.");
                this.surname = value;
            }
        }

        public void SetIdentity(IUserIdentity identity)
        {
            throw new NotImplementedException();
        }
    }
}
