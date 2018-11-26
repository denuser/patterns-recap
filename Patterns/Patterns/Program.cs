using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patterns.Duck;

namespace Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            // Duck
            var mallard = new MallardDuck();
            mallard.PerformQuack();
            mallard.PerformFly();

            Console.ReadLine();
        }
    }
}
