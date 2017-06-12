using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecificationDemo.Validation.Infrastructure
{
    internal class Composite<T> : Specification<T>
    {
        private Func<IEnumerable<bool>, bool> CompositionFunction { get; }
        private IEnumerable<Specification<T>> Subspecification { get; }

        public Composite(Func<IEnumerable<bool>, bool> compositionFunction,
                                                params Specification<T>[]subspecifications)
        {
            this.CompositionFunction = compositionFunction;
            this.Subspecification = subspecifications;
        }

        public override bool IsSatisfiedBy(T obj) =>
            this.CompositionFunction(
                this.Subspecification.Select(spec => spec.IsSatisfiedBy(obj)));
    }
}
