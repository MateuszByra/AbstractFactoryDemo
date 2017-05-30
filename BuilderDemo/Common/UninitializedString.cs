using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDemo.Common
{
    internal class UninitializedString : INonEmptyStringState
    {
        public string Get() => throw new InvalidOperationException();

        public INonEmptyStringState Set(string value) => new NonEmptyString(value);
    }
}
