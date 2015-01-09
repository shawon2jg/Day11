using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonNameApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Person aPerson = new Person("Tahsina", "Bristy");
            Console.WriteLine(aPerson.GetFullName());
            Console.WriteLine(aPerson.GetReverseName());

            Console.WriteLine();

            Person bPerson = new Person("Tayabur", "Rahman", "Masud");
            Console.WriteLine(bPerson.GetFullName());
            Console.WriteLine(bPerson.GetReverseName());

            Console.ReadKey();
        }
    }
}
