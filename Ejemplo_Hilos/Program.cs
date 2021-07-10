using System;
using System.Threading;

namespace Ejemplo_Hilos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Ejemplo de programación por multihilos--");
            Console.WriteLine();
            Console.WriteLine("**************************************************************************************************");

            //Creación de hilos
            Thread Chef1 = new Thread(new ThreadStart(chef_1));
            Thread Chef2 = new Thread(new ThreadStart(chef_2));
            Thread Chef3 = new Thread(new ThreadStart(chef_3));

            //Invocando métodos
            Chef1.Start();
            Chef2.Start();
            Chef3.Start();
        }

        public static void chef_1()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Chef cocinando pizza...");
                System.Threading.Thread.Sleep(1000);
            }
            
        }

        public static void chef_2()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Chef cocinando sopa...");
                System.Threading.Thread.Sleep(1000);
            }

        }

        public static void chef_3()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Chef cocinando pollo...");
                System.Threading.Thread.Sleep(1000);
            }

        }
    }
}
