using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Multithreading
{
    class Caja
    {

        public string name;
        public int numCaja;
        public int clients;

        public void MostrarCaja()
        {

          
            for ( ; clients>=0; clients--)
            {
                
                Console.WriteLine($"Bienvenido/a a la caja número {this.numCaja}" +
                                  $" {this.name} lo esta atendiendo\n " +
                                  $"Registramos y tomamos sus producto\n" +
                                  $"Quedan {this.clients} clientes en la fila\n");
          
                Console.WriteLine($"Procesando orden en caja {this.numCaja}\n");

         
                Console.WriteLine($"Orden completada en caja {this.numCaja}!!!\n");
                Thread.Sleep(1000);
                
            }
            Console.WriteLine($"Se han atendido todos los cliente de la caja {this.numCaja}!!\n");
        }

    }
}
