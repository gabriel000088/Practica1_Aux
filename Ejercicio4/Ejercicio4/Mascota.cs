using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    
     public class Mascota
    {
        public String nombre { get; set; }
        public int edad { get; set; }
        public String raza { get; set; }
        public string sexo { get; set; }


        public virtual void mostrar_mascota()
        {
            Console.WriteLine("---Mi Mascota---\nNombre:" + nombre + "\nEdad: " + edad + "\nRaza: " + raza + "\nSexo: " + sexo);
        }
    }
}
