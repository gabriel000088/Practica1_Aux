using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    public static class NumeroEnLetras
    {
        static string[] Unidades = { "cero", "uno", "dos", "tres", "cuatro", "cinco", "seis", "siete", "ocho", "nueve" }; //puede usarse fuera pero con estatic

        public static void MostrarEnLetras(int numero)
        {

            string[] Decenas = { "diez", "once", "doce", "trece", "catorce", "quince", "dieciseis", "diecisiete", "dieciocho", "diecinueve" };
            string[] Decenas2 = { "veinte", "treinta", "cuarenta", "cincuenta", "sesenta", "setenta", "ochenta", "noventa" };

            if (numero >= 0 && numero < 10)
            {
                Console.WriteLine(Unidades[numero]);//la variable numero indicará la posicion en el vector de Unidades
            }
            else if (numero >= 10 && numero < 20)
            {
                Console.WriteLine(Decenas[numero - 10]);//se le resta -10 a la variable "ingresar" xq solo tenemos 10 elementos en el vector Decenas
            }
            else if (numero >= 20 && numero < 100)
            {
                int dec2 = numero / 10; //Ej: 62 -> saca el 6
                int unid2 = numero % 10;//Ej: 62 ->saca el 2
                string enLetras = Decenas2[dec2 - 2];// resta -2 para llegar a la posicion 0 en el vector Decenas2 Ej: dec2=6-2 -> en el vector 4 esta "sesenta"
                if (unid2 > 0)  //esta condicion para cuando la unidad sea 0 no diga "sesenta y cero"
                {
                    enLetras += " y " + Unidades[unid2];//concatenar Ej: Sesenta y dos
                }
                Console.WriteLine(enLetras);
            }
            else if (numero == 100)
            {
                Console.WriteLine("cien");
            }
            else
            {
                Console.WriteLine("Número fuera de rango.");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            do
            {
                //NumeroEnLetras ms = new NumeroEnLetras();
                Console.Write("Ingrese un número entre 0 y 100 o Ingrese -1 para Finalizar: ");
                numero = Convert.ToInt32(Console.ReadLine());
                NumeroEnLetras.MostrarEnLetras(numero);
            } while (numero != -1);
            Console.ReadKey();
        }
    }
}

