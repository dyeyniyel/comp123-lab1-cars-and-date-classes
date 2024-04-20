using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_01_lab_02_Cars_W
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //cars with 4 arguments
            Car c = new Car("Honda", 2009, 4500.19, true);
            Car d = new Car("Chevrolet", 2010, 6500.25, true);
            Car e = new Car("Ford", 2011, 5500.22, true);
            Car f = new Car("Ferrari", 2012, 9500, false);

            //displaying cars with below format
            Console.WriteLine(c.ToString() + '\n' + d.ToString() + '\n' + e.ToString() + '\n' + f.ToString());
            Console.ReadKey();
        }
    }
}
