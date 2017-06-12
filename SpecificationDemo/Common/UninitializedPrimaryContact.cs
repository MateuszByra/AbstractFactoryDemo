using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpecificationDemo.Interfaces;

namespace SpecificationDemo.Common
{
    internal class UninitializedPrimaryContact : IPrimaryContactState
    {
        private Func<IContactInfo, bool> Predicate { get; }

        public UninitializedPrimaryContact(Func<IContactInfo,bool> predicate)
        {
            if (predicate == null)
                throw new ArgumentNullException();
            this.Predicate = predicate;
        }

        public IContactInfo Get() => throw new InvalidOperationException();

        public IPrimaryContactState Set(IContactInfo contact) => 
            new ValidPrimaryContact(contact, Predicate);
    }
}
