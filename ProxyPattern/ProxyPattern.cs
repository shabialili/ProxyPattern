using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public interface ISubject
    {
        void Sum(int x, int y);
        void Div(int x, int y);
        void Multi(int x, int y);   
        void Sub(int x, int y); 
    }
    public class RealSubject : ISubject
    {
        public void Sum(int x, int y)
        {
            Console.WriteLine("x+y = {2} ",x,y, x+y);        
        }

        public void Div(int x, int y)
        {
            Console.WriteLine("x/y = {2}",x,y, x/y);
        }

        public void Multi(int x, int y)
        {
            Console.WriteLine("x*y = {2}",x,y, x*y);
        }

        public void Sub(int x, int y)
        {
            Console.WriteLine("x-y = {2}",x,y, x - y);
        }
    }
    public class Proxy
    {
        private RealSubject real = new RealSubject();
        public void Sum(int x, int y)
        {
            Console.WriteLine();
            real.Sum(x, y);
        }

        public void Div(int x, int y)
        {
            Console.WriteLine();
            real.Div(x, y);
        }

        public void Multi(int x, int y)
        {
            Console.WriteLine();
            real.Multi(x, y);
        }

        public void Sub(int x, int y)
        {
            Console.WriteLine();
            real.Sub(x, y);
        }
    }
}
