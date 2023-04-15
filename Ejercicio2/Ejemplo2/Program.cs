using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejemplo2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("introdusca dos numeros");
            int num1 = int.Parse (Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("la suma es:" + Operacion.Suma(num1, num2));
            Console.WriteLine("la resta es:" + Operacion.resta(num1, num2));
            Console.WriteLine("la multiplicacion es:" + Operacion.multiplicacion(num1, num2));
            Console.WriteLine("la division es:" + Operacion.division(num1, num2));
            Console.WriteLine("la potencia es es:" + Operacion.potencia(num1, num2));*/


            Console.WriteLine("introdusca ub numero");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("El numero es perfecto?: "+Operacion.Esperfecto(num1));
            Console.WriteLine("Es nuemro es primo?: " + Operacion.Numprimo(num1));

            Console.ReadKey();
        }
    }
}
