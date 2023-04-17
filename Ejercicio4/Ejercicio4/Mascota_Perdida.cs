using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    public class Mascota_Perdida:Mascota
    {
        public string motivo { get; set; }
        public string fecha_perdida { get; set; }

        public override void mostrar_mascota()
        {
            Console.WriteLine("\n---Mascota Perdida---"+"\nNombre: "+nombre+"\nEdad: "+edad+"\nRaza: "+raza+"\nSexo: "+sexo+"\nMotivo: "+motivo+"\nFecha de Pérdida: "+fecha_perdida);
        }
    }
}
