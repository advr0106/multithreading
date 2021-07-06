using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Multithreading
{
    class Program
    {
        static void Main(string[] args)
        {
            Caja caja1 = new Caja(){name = "Jocho", numCaja = 1, clients = 5};
            Caja caja2 = new Caja() { name = "Naomys", numCaja = 2, clients = 5 };

            Thread th1 = new Thread(new ThreadStart(caja1.MostrarCaja));
            Thread th2 = new Thread(new ThreadStart(caja2.MostrarCaja));

            th1.Start();
            th2.Start();

            th1.Join();
            th2.Join();


            Console.ReadKey();
        }
       
    }
}
