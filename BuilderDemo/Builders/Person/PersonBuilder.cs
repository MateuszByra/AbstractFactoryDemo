using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDemo.Builders.Person
{
    public class PersonBuilder
    {
        private Func<string> GetValidFirstName { get; set; } =
            () => { throw new InvalidOperationException(); };

        private Func<string> GetValidLastName { get; set; } =
         () => { throw new InvalidOperationException(); };

        public void SetFirstName(string firstName)
        {
            if (string.IsNullOrEmpty(firstName))
                throw new ArgumentException();
            this.GetValidFirstName = () => firstName;
        }

        public void SetLastName(string lastName)
        {
            if (string.IsNullOrEmpty(lastName))
                throw new ArgumentException();
            this.GetValidLastName = () => lastName;
        }

        public Models.Person Build()
        {
            return new Models.Person(this.GetValidFirstName(), GetValidLastName());
        }
    }
}
