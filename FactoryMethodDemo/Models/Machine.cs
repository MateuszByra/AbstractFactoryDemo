using FactoryMethodDemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDemo.Models
{
    public class Machine : IUser
    {
        public Producer Producer { get; }
        public string Model { get; }
        public LegalEntity Owner { get; }

        public IContactInfo PrimaryContact => this.Owner.EmailAddress;

        public Machine(Producer producer, string model, LegalEntity owner)
        {
            if (producer == null)
                throw new ArgumentNullException(nameof(producer));
            if (string.IsNullOrEmpty(model))
                throw new ArgumentException("Model name must be non-empty");
            if (owner == null)
                throw new ArgumentNullException(nameof(owner));

            this.Producer = producer;
            this.Model = model;
            this.Owner = owner;
        }

        public void SetIdentity(IUserIdentity identity)
        {
            
        }

        public bool CanAcceptIdentity(IUserIdentity identity)
        {
            return identity is MacAddress;
        }

        public void Add(IContactInfo contact)
        {
            this.Owner.Add(contact);
        }

        public void SetPrimaryContact(IContactInfo contact)
        {
            // NOTE: It would be better to throw if contact is not email address
            // but that requires a new Boolean method like IsValidPrimaryContact
            // so that code contract can be implemented properly

            EmailAddress emailAddress = contact as EmailAddress;
            if (emailAddress == null)
                this.Owner.Add(contact);
            else
                this.Owner.SetEmailAddress(emailAddress);
        }
    }
}
