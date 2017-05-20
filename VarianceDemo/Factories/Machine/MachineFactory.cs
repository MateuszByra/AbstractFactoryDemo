using VarianceDemo.Factories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VarianceDemo.Interfaces;
using VarianceDemo.Models;

namespace VarianceDemo.Factories.Machine
{
    public class MachineFactory : IUserFactory<Models.Machine>
    {
        private Dictionary<string, Producer> NameToProducer { get; }

        public MachineFactory(Dictionary<string, Producer> nameToProducer)
        {
            if (nameToProducer == null)
                throw new ArgumentNullException(nameof(nameToProducer));
            this.NameToProducer = nameToProducer;
        }

        private Producer GetProducer(string name)
        {
            Producer producer;
            if (!NameToProducer.TryGetValue(name, out producer))
                throw new ArgumentException();
            return producer;
        }

        public IUser CreateUser(string name1, string name2)
        {
            Producer producer = GetProducer(name1);
            return new Models.Machine(producer, name2);
        }

        public IUserIdentity CreateIdentity()
        {
            return new MacAddress();
        }

        Models.Machine IUserFactory<Models.Machine>.CreateUser(string name1, string name2)
        {
            Producer producer = GetProducer(name1);
            return new Models.Machine(producer, name2);
        }
    }
}
