using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDemo.Builders.Interfaces
{
    public interface IMachineBuilder
    {
        Models.Machine Build();
    }
}
