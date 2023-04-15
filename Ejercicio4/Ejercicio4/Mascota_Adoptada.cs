using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    public class Mascota_Adoptada:Mascota
    {
        public string nombre_dueno;
        public double pago_mascota;
        public string fecha_adop; //DateTime

        public override void mostrar_mascota()
        {
            Console.WriteLine("---Mascota Adoptada---\nNombre: {0}\nEdad: {1}\nRaza: {2}\nSexo: {3}\nDueño: {4}\nPago: {5}\nFecha de Adopción: {6}\n", nombre, edad, raza, sexo, nombre_dueno, pago_mascota, fecha_adop);
        }
    }
}
