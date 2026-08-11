using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programacion2.Clase01
{
    public class metodosFunciones
    {
        public static void saludar()
        {
            Console.WriteLine("Bienvenido a la clase 01-a ");
                }

        public static double Suma (double a , double b)
        {

            if (a > b)
            {
                Console.WriteLine("El 1er nro es mayor" + a);
                Console.WriteLine("La suma es ");
                return a + b;
            }
            else
            {
                return a + b;
            }
        }

        public static double Resta(double a, double b)
        {
            return a - b;
        }

        public static double Multiplicacion(double a, double b)
        {
            return a * b;
        }

        public static double Division(double a, double b)
        {
            return a / b;
        }

        public static double Residuo(double a, double b)
        {
            return a % b;
        }

    }
}
