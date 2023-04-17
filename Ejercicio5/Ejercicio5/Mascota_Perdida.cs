using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    internal class Mascota_Perdida:Mascota
    {
        public string Motivo { get; set; }
        public DateTime Fecha_Perdida { get; set; }

        public override void Mostrar_Mascota()
        {
            List<Mascota_Perdida> listamascota = new List<Mascota_Perdida>();

            listamascota.Add(new Mascota_Perdida()
            {
                Motivo = "Extravio",
                Fecha_Perdida = Convert.ToDateTime("08/01/2002"),
            });

            listamascota.Add(new Mascota_Perdida()
            {
                Motivo = "Robo",
                Fecha_Perdida = Convert.ToDateTime("08/01/2015"),
            });

            listamascota.Add(new Mascota_Perdida()
            {
                Motivo = "Escapo del Jardín",
                Fecha_Perdida = Convert.ToDateTime("08/01/2002"),
            });
            listamascota.Add(new Mascota_Perdida()
            {
                Motivo = "En la plaza Sucre",
                Fecha_Perdida = Convert.ToDateTime("08/01/2002"),
            });
            listamascota.Add(new Mascota_Perdida()
            {
                Motivo = "Escapo de la casa",
                Fecha_Perdida = Convert.ToDateTime("08/01/2002"),
            });
            listamascota.Add(new Mascota_Perdida()
            {
                Motivo = "Extravio",
                Fecha_Perdida = Convert.ToDateTime("04/01/2012"),
            });

            Console.WriteLine("\n-----------MASCOTAS ADOPTADAS-----------");

            promedio_P(listamascota);
        }

        private void promedio_P(List<Mascota_Perdida> listamascota)
        {
            var mostrarPromedioPago = listamascota.Where(p => p.Motivo == "IVAN FLORES" || p.Motivo == "Roberto FLORES"); //p.Nombre_Dueño == "Roberto FLORES"
            foreach (var datos in mostrarPromedioPago)
            {
                Console.WriteLine("Dueño: " + datos.Motivo + " Fecha perdida: "+datos.Fecha_Perdida);
            }
            
        }
    }
}
