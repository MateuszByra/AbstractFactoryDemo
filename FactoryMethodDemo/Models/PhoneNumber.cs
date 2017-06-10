using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDemo.Models
{
    public class PhoneNumber
    {
        private int CountryCode { get; }
        private int AreaCode { get; }
        private int Number { get; }

        public PhoneNumber(int countryCode, int areaCode, int number)
        {
            if (countryCode < 0)
                throw new ArgumentException();
            if (areaCode < 0)
                throw new ArgumentException();
            if (number < 0)
                throw new ArgumentException();

            this.CountryCode = countryCode;
            this.AreaCode = areaCode;
            this.Number = number;
        }

        public override string ToString() => $"+{this.CountryCode}({this.AreaCode}){this.Number}";

    }
}
