using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    public class Mascota_Perdida:Mascota
    {
        public string motivo;
        public string fecha_perdida;

        public override void mostrar_mascota()
        {
            Console.WriteLine("---Mascota Perdida---\n Nombre: {0}\nEdad: {1}\nRaza: {2}\nSexo: {3}\nMotivo: {4}\nFecha de Pérdida: {5}\n", nombre, edad, raza, sexo, motivo, fecha_perdida);
        }
    }
}
