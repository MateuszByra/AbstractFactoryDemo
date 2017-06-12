using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecificationDemo.Validation.Infrastructure
{
    public class NonEmptyString : Specification<string>
    {
        public override bool IsSatisfiedBy(string obj)=>
            !string.IsNullOrEmpty(obj);
    }
}
