using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Co728853_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("peter rule the world");
            Download();
            Console.ReadLine();
        }

        static void Download()
        {
            Thread.Sleep(4000);
            Console.WriteLine("Downloading Complete!!!!#@");
        }
    }
}
