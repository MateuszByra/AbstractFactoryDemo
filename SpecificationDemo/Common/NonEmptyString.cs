using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecificationDemo.Common
{
    internal class NonEmptyString : INonEmptyStringState
    {
        private string Value { get; }

        public NonEmptyString(string value)
        {
            if (string.IsNullOrEmpty(value))
                throw new ArgumentException();

            Value = value;
        }

        public string Get() => this.Value;

        public INonEmptyStringState Set(string value) => new NonEmptyString(value);
    }
}
