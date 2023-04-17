using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mascota masc = new Mascota();
            masc.nombre = "Fido";
            masc.edad = 3;
            masc.raza = "Poodle";
            masc.sexo = "M";

            Mascota_Adoptada adop = new Mascota_Adoptada();
            adop.nombre = "Max";
            adop.edad = 2;
            adop.raza = "Golden Retriever";
            adop.sexo = "M";
            adop.nombre_dueno = "Juan Perez";
            adop.pago_mascota = 500;
            adop.fecha_adop = "31/03/2023"; //new DateTime(2023, 3, 31)

            Mascota_Perdida perd = new Mascota_Perdida();
            perd.nombre = "Lola";
            perd.edad = 1;
            perd.raza = "ChawChaw";
            perd.sexo = "F";
            perd.motivo = "Escapó del jardín";
            perd.fecha_perdida = "01/03/2023";//new DateTime(2023, 4, 1)

            /*Mascota[] misMascotas = new Mascota[3];
            misMascotas[0] = miMascota;
            misMascotas[1] = miMascotaAdoptada;
            misMascotas[2] = miMascotaPerdida;*/

            Console.WriteLine("--------Mostrando mis mascotas--------\n");

            //foreach (Mascota mascota in misMascotas)
            //{
            masc.mostrar_mascota();
            adop.mostrar_mascota();
            perd.mostrar_mascota();
            //}
            Console.ReadKey();
        }
    }
}
