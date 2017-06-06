using BuilderDemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDemo.Builders.Person.Interfaces
{
    public interface IContactHolder
    {
        IContactHolder Add(IContactInfo contact);
        IPersonBuilder NoMoreContacts();
    }
}
