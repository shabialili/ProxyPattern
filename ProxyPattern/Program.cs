using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Proxy result = new Proxy();
            result.Sum(10, 5);
            result.Sub(10, 5);
            result.Div(10, 5);
            result.Multi(10, 5);

            Console.ReadLine();

        }
    }
}
