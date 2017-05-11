using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VarianceDemo.Factories.Interfaces;
using VarianceDemo.Interfaces;

namespace VarianceDemo
{
    class Program
    {
        static void RegisterUser(IUserFactory<IUser> userFactory)
        {
            IUserFactory<ITicketHolder> lessDerivedFactory = userFactory; // variable on the left is equally of less derived (mniej pochodna - nadrzedna).
        }

        static void Main(string[] args)
        {
        }
    }
}
