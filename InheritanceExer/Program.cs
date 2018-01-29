using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExer
{
    class Program
    {
        static void Main(string[] args)
        {
            var stacks = new Stack();

           stacks.Push("1");
           stacks.Push("2");
           stacks.Push("3");

           Console.WriteLine(stacks.Pop());
           Console.WriteLine(stacks.Pop());
           Console.WriteLine(stacks.Pop());

           stacks.Clear();
        }
    }
}
