using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejemplo2
{
    static class Operacion
    {
        //---------EJERCICIOS ARITMETICOS
        public static int Suma(int x, int y){
        return x+y;
        }
        public static int resta(int x, int y)
        {
            return x - y;
        }
        public static int multiplicacion(int x, int y)
        {
            return x * y;
        }
        public static float division(int x, int y)
        {
            return (float) x / y;
        }
        public static double potencia(int x, int y)
        {
            return Math.Pow(x,y);
        }
        //----------------EJERCICICIO DE NUMERO PERFECTO
    public static bool Esperfecto(int numero){
        int contador = 0;
        for (int i = 1; i < numero; i++ )
            if (numero%i==0) {
                contador = i + contador;
            }
        if (contador == numero)
            return true;
        else
            return false;
         }
        //----------------EJERCICIO DE NUMERO PRIMO
    public static bool Numprimo(int numero){
        int contador = 0;
        for (int i = 1; i <= numero; i++)

            if (numero % i == 0)
            {
                contador++;
            }
            if (contador == 2)
                return true;

            else
                return false;
        
    }
    }
}
