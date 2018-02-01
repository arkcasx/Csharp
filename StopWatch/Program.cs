using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace StopWatch
{
    
    class Program
    {
        static void Main(string[] args)
        {
            var stopWatch = new Watch();

            while (true)
            {
                Console.WriteLine("Type start or stop");
                var text = Console.ReadLine();

                switch (text)
                {
                    case "start":
                        stopWatch.Start();
                        break;
                    case "stop":
                        Console.WriteLine(stopWatch.StopTime());
                        break;
                }
            }
            

            
        }
    }
}
