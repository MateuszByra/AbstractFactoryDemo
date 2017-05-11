using VarianceDemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarianceDemo.Factories.Interfaces
{
    public interface IUserFactory<out TUser>
    {
        TUser CreateUser(string name1, string name2);
    }
}
