using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    internal class Mascota_Adoptada:Mascota
    {
        public string Nombre_Dueño { get; set; }
        public int Pago_Mascota { get; set; }
        public DateTime Fecha_Adopcion { get; set; }

        public override void Mostrar_Mascota()
        {
            List<Mascota_Adoptada> listamascota = new List<Mascota_Adoptada>();

            listamascota.Add(new Mascota_Adoptada()
            {
                Nombre_Dueño = "IVAN FLORES",
                Pago_Mascota = 550,
                Fecha_Adopcion = Convert.ToDateTime("08/01/2002"),
            });

            listamascota.Add(new Mascota_Adoptada()
            {
                Nombre_Dueño = "IVAN FLORES",
                Pago_Mascota = 310,
                Fecha_Adopcion = Convert.ToDateTime("08/01/2002"),
            });

            listamascota.Add(new Mascota_Adoptada()
            {
                Nombre_Dueño = "IVAN FLORES",
                Pago_Mascota = 265,
                Fecha_Adopcion = Convert.ToDateTime("08/01/2002"),
            });
            listamascota.Add(new Mascota_Adoptada()
            {
                Nombre_Dueño = "IVAN FLORES",
                Pago_Mascota = 150,
                Fecha_Adopcion = Convert.ToDateTime("08/01/2002"),
            });
            listamascota.Add(new Mascota_Adoptada()
            {
                Nombre_Dueño = "IVAN FLORES",
                Pago_Mascota = 412,
                Fecha_Adopcion = Convert.ToDateTime("08/01/2002"),
            });
            listamascota.Add(new Mascota_Adoptada()
            {
                Nombre_Dueño = "IVAN FLORES",
                Pago_Mascota = 400,
                Fecha_Adopcion = Convert.ToDateTime("08/01/2002"),
            });
            
            //Console.WriteLine("\n----------MASCOTAS ADOPTADAS-----------");

            promedio_Pago(listamascota);
        }

        private void promedio_Pago(List<Mascota_Adoptada> listamascota)
        {
            var mostrarPromedioPago = listamascota.Average(p=>p.Pago_Mascota);
            Console.WriteLine("\n----------El promedio del pago de las mascotas adoptadas es: " + mostrarPromedioPago);
        }
    }
}
