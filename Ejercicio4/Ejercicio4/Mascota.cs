using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    
     public class Mascota
    {
        public string nombre;
        public int edad;
        public string raza;
        public char sexo;

        public virtual void mostrar_mascota()
        {
            Console.WriteLine("---Mi Mascota---\nNombre: {0}\nEdad: {1}\nRaza: {2}\nSexo: {3}\n", nombre, edad, raza, sexo);
        }

    }
}
