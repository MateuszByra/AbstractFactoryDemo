using BuilderDemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDemo.Models
{
    public class Machine : IUser
    {
        public Producer Producer { get; }
        public string Model { get; }

        public Machine(Producer producer, string model)
        {
            if (producer == null)
                throw new ArgumentNullException(nameof(producer));
            if (string.IsNullOrEmpty(model))
                throw new ArgumentException("Model name must be non-empty");

            this.Producer = producer;
            this.Model = model;
        }

        public void SetIdentity(IUserIdentity identity)
        {
            
        }

        public bool CanAcceptIdentity(IUserIdentity identity)
        {
            throw new NotImplementedException();
        }

        public void Add(IContactInfo contact)
        {
            throw new NotImplementedException();
        }

        public void SetPrimaryContact(IContactInfo contact)
        {
            throw new NotImplementedException();
        }
    }
}
