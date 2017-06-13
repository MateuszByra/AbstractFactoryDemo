using SpecificationDemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecificationDemo.Models
{
    public class EmailAddress : IContactInfo
    {
        public string Address { get; set; }

        public override int GetHashCode()
        {
            return this.Address.ToLower().GetHashCode();
        }

        public override bool Equals(object obj)
        {

            EmailAddress email = obj as EmailAddress;

            if (email == null)
                return false;

            return string.Compare(this.Address, email.Address,
                                    StringComparison.InvariantCultureIgnoreCase) == 0;

        }

        public override string ToString() => $"{this.Address}";

    }
}
