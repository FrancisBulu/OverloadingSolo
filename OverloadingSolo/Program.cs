using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingSolo
{
    class Program
    {
        static void Main(string[] args)
        {

            Print(11);
            Print(0, "val");
        }
        static void Print(int a)
        {
            Console.WriteLine("Value: " + a);
        }
        static void Print(int b, string value)
        {
            Console.WriteLine("New value: "+ value + b);
        }
    }
}
