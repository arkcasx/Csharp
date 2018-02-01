using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Use to have less code for getter and setter
namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person(new DateTime(1995, 07, 21));
            Console.WriteLine(person.Age);
        }
    }
}
