using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Ejercicio2
{
    public static class Series
    {
        static int almacen = 1;
        public static void Serie1(int numero)
        {
            string mostrar = "";
            
            for (int i=1;i<=numero;i++)
            {
                almacen *= i;
                mostrar += almacen + ", ";
            }
            Console.WriteLine("Serie 1: "+mostrar);
            almacen = 1;  //xd
        }
        
        public static void Serie2(int numero)
        {
            string mostrar = "";
           
            for (int i=1; i <= numero; i++)
            {
                //almacen = 1;
                almacen +=almacen;
                mostrar += almacen + ", ";
            }
            Console.WriteLine("Serie 2: "+mostrar);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            Console.WriteLine("Ingrese un numero: ");
            numero = Convert.ToInt32(Console.ReadLine());
            Series.Serie1(numero);
            Series.Serie2(numero);

            Console.ReadKey();
        }
    }
}
