using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonNameApp
{
    class Person
    {
        private string firstName;
        private string middleName;
        private string lastName;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string MiddleName
        {
            get { return middleName; }
            set { middleName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }


        public Person(string firstName, string middleName, string lastName) : this(firstName, lastName)
        {
            MiddleName = middleName;
        }

        public Person(string firstName, string lastName) : this()
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public Person()
        {
            
        }

        public string GetFullName()
        {
            return FirstName + " " + MiddleName + " " + LastName;
        }

        public string GetReverseName()
        {
            string fullName = GetFullName();
            string reverse = String.Empty;
            for (int i = fullName.Length - 1; i > -1; i--)
            {
                reverse += fullName[i];
            }
            return reverse;
        }
    }
}
