using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxing
{
    class Program
    {
        static void Main(string[] args)
        {

            
           
           
            //Boxing
            //problems no type saftey
            var list = new ArrayList();
            list.Add(1);
            list.Add("Clark"); //Boxing wont happen cause string
            list.Add(DateTime.Today);

            //Unboxing
            var number = (int) list[1];
            //Generic List
            //no boxing happens
            // type safety


            var anotherList = new List<int>();
            var names = new List<string>();

            names.Add("name clark");
        }
    }
}
