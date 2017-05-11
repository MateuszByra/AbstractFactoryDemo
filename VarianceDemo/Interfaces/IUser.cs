using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarianceDemo.Interfaces
{
    public interface ITicketHolder
    {

    }

    public interface IUser : ITicketHolder
    {
        void SetIdentity(IUserIdentity identity);
    }
}
