using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Kocka
{
    public class NegyszogClass
    {
        private int a=3, kerulet, terulet;

        public void SetTerulet()
        {
            this.terulet = a * a;
        }
        public void SetKerulet()
        {
            this.kerulet = 4 * a;
        }

        public int GetTerulet()
        {
            return this.terulet;
        }
        public int GetKerulet()
        {
            return this.kerulet;
        }

    }
    class Program
    {

        static void Main(string[] args)
        {
            
            NegyszogClass negyszog = new NegyszogClass();
            
            negyszog.SetKerulet();
            negyszog.SetTerulet();
            Console.WriteLine("A Négyszög kerulete: {0} és területe: {0}");
                negyszog.GetKerulet();
                negyszog.GetTerulet();
            Console.ReadKey();
        }
    }
}
