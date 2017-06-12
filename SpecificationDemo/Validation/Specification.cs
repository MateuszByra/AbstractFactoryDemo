using SpecificationDemo.Validation.Infrastructure;
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

        public Specification<T> And(Specification<T> other) =>
            new Composite<T>((results) => results.All(res => res == true), this, other);

        public Specification<T> Or(Specification<T> other) =>
          new Composite<T>((results) => results.Any(res => res == true), this, other);

        public Specification<T> Not()=>
          new Transform<T>(res=>!res,this);
    }
}
