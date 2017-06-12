using System;

namespace SpecificationDemo.Validation.Infrastructure
{
    public class NotNull<T> : Specification<T>
    {
        public override bool IsSatisfiedBy(T obj)=>
            !object.ReferenceEquals(obj, null);
    }
}
