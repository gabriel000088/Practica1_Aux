using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    public class Mascota_Adoptada:Mascota
    {
        public string nombre_dueno { get; set; }
        public double pago_mascota { get; set; }
        public string fecha_adop { get; set; } //DateTime

        public override void mostrar_mascota()
        {
            Console.WriteLine("\n---Mascota Adoptada---"+"\nNombre: "+nombre+"\nEdad: "+edad+"\nRaza: "+raza+"\nSexo: "+sexo+"\nDueño: "+nombre_dueno+"\nPago: "+pago_mascota+"\nFecha de Adopción: "+fecha_adop);
        }
    }
}
