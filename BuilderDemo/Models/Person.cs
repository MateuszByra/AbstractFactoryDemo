using BuilderDemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDemo.Models
{
    public class Person : IUser
    {
        public string Name { get; }
        public string Surname { get; }

        private IList<IContactInfo> Contacts { get; } = new List<IContactInfo>();
        private IContactInfo PrimaryContact { get; set; }

        public Person(string name, string surname)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentException();

            if (string.IsNullOrEmpty(surname))
                throw new ArgumentException();

            Name = name;
            Surname = surname;
        }

        public void SetIdentity(IUserIdentity identity)
        {
        }

        public bool CanAcceptIdentity(IUserIdentity identity) =>
            identity is IdentityCard;

        public override string ToString() => $"{Name} {Surname}";

        public void Add(IContactInfo contact)
        {
            if (contact == null)
                throw new ArgumentNullException();
            if (Contacts.Contains(contact))
                throw new ArgumentException();

            Contacts.Add(contact);
        }

        public void SetPrimaryContact(IContactInfo contact)
        {
            if (contact == null)
                throw new ArgumentNullException();
            if (!Contacts.Contains(contact))
                throw new ArgumentException();

            PrimaryContact = contact;
        }
    }
}
