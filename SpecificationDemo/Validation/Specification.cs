using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecificationDemo.Validation
{
    public abstract class Specification<T>
    {
        public abstract bool IsSatisfiedBy(T obj);
    }
}
