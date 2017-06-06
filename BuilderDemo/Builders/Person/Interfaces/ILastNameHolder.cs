using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDemo.Builders.Person.Interfaces
{
    public interface ILastNameHolder
    {
        IPrimaryContactHolder SetLastName(string surname);
    }
}
