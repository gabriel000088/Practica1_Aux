using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    internal class Mascota
    {
        public String Nombre { get; set; }
        public int Edad { get; set; }
        public String Raza { get; set; }
        public string Sexo { get; set; }

        public virtual void Mostrar_Mascota()
        {
            List<Mascota> listamascota = new List<Mascota>();

            listamascota.Add(new Mascota()
            {
                Nombre = "Bobita",
                Edad = 1,
                Raza = "Chiwawa",
                Sexo = "F"
            });

            listamascota.Add(new Mascota()
            {
                Nombre = "Rodolf",
                Edad = 1,
                Raza = "Pastor Aleman",
                Sexo = "M"
            });

            listamascota.Add(new Mascota()
            {
                Nombre = "Cali",
                Edad = 3,
                Raza = "ChawChaw",
                Sexo = "M"
            });
            listamascota.Add(new Mascota()
            {
                Nombre = "Oso",
                Edad = 0,
                Raza = "Chiwawa",
                Sexo = "M"
            });
            listamascota.Add(new Mascota()
            {
                Nombre = "Nana",
                Edad = 1,
                Raza = "Beagle",
                Sexo = "F"
            });
            listamascota.Add(new Mascota()
            {
                Nombre = "WanWan",
                Edad = 2,
                Raza = "Chiwawa",
                Sexo = "F"
            });
            Console.WriteLine("-----------LOS DATOS DE LA MASCOTA ES-----------");
            foreach (var masc in listamascota)
            {
                Console.WriteLine("Nombre: " + masc.Nombre + " Edad: " + masc.Edad + " Raza: " + masc.Raza + " Sexo: " + masc.Sexo);
            }

            Prom_Edad(listamascota);
            Raza_Chiwawa(listamascota);
            Edad_Mascota(listamascota);
        }

        private void Edad_Mascota(List<Mascota> listamascota)
        {
            var mostEdad = from edmasc in listamascota
                       where edmasc.Edad < 2
                       select edmasc;
            Console.WriteLine("\n----------Las mascotas menores a 2 años son:");
            foreach(Mascota most in mostEdad)
            {
                Console.WriteLine("Nombre: " + most.Nombre + " Edad: " + most.Edad + " Raza: " + most.Raza + " Sexo: " + most.Sexo);
            }
        }

        private static void Prom_Edad(List<Mascota> listamascota)
        {
            var mostrarProm = listamascota.Average(p => p.Edad);
            Console.WriteLine("\n----------El promedio de edades es: " + mostrarProm);
        }
        private void Raza_Chiwawa(List<Mascota> listamascota)
        {
            var mostrarRaza= from masco in listamascota
                             where masco.Raza=="Chiwawa" && masco.Sexo=="F"
                             select masco;
            Console.WriteLine("\n----------Las mascotas que son de raza Chiwawa y Sexo F son:");
            foreach (var most in mostrarRaza)
            {
                Console.WriteLine("Nombre: " + most.Nombre+" Edad: "+most.Edad+" Raza: "+most.Raza+" Sexo: "+most.Sexo);
            }
        }
    }
}
