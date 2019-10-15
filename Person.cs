using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonInformationAppWalkthrough2
{
    class Person
    {
        private string firstName;
        private string middleName;
        private string lastName;
        private int point;

        public  string FirstName { set; get; }
        public  string MiddleName { set; get; }
        public string LastName { set; get; }

        public Person()
        {
            point = 10;
        }

        public Person(string firstName, string lastName):this()
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public Person(string firstName, string middleName, string lastName):this(firstName,lastName)
        {
           // this.firstName = firstName;
            this.MiddleName = middleName;
           // this.lastName = lastName;
        }

        public string GetFullName()
        {
            return firstName + " " + middleName + " " + lastName;
        }
        public string GetReverseName()
        {
            return null;
        }
    }
}
