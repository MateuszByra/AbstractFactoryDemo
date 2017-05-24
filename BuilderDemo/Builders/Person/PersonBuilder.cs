﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDemo.Builders.Person
{
    public class PersonBuilder
    {
        private string FirstName { get; set; }
        private string LastName { get; set; }

        public void SetFirstName(string firstName)
        {
            this.FirstName = firstName;
        }

        public void SetLastName(string lastName)
        {
            this.LastName = lastName;
        }

        public Models.Person Build()
        {
            Validate();
            return new Models.Person(FirstName, LastName);
        }

        private void Validate()
        {
            if (string.IsNullOrEmpty(this.FirstName) ||
                string.IsNullOrEmpty(this.LastName))
                throw new InvalidOperationException(); //invalid operation instead of argumentException
            //because build method have no arguments
        }
    }
}
