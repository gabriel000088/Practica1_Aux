using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
             Mascota masco = new Mascota();
            Mascota_Adoptada masc2=new Mascota_Adoptada();
            //Mascota_Perdida masc3=new Mascota_Perdida();

            masco.Mostrar_Mascota();
            masc2.Mostrar_Mascota();
            //masc3.Mostrar_Mascota();
            Console.ReadKey();
        }
    }
}