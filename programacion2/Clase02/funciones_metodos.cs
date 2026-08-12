using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programacion2.Clase02
{
    public class funciones_metodos
    {

        public static void SALUDAR()
        {
            Console.WriteLine(">>>>>>>CLASE 02<<>>>>>");
            Console.WriteLine(">>>>CONDICIONANTES<<<<");
        }

        /*
        public static double datosentrada(double a , double b)
        {
            Console.WriteLine("Ingresa un valor para a");
            double a = double.Parse(Console.ReadLine());
            return (a+ b);
        }
        */

        public static  (double,double) datosentrada()
        {
            Console.WriteLine("Ingresa un valor para a");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa un valor para b");
            double b = double.Parse(Console.ReadLine());

            return (a,b);

        }

        public static double validacion(double a, double b)
        {
            //Console.WriteLine("Ingresa un valor para a");
            //double a = double.Parse(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine("El numero es mayor");
                return a;
            }else
                if (a < b) {
                Console.WriteLine("El numero " + b + " Es mayor ");
                return b;
                    }

            return 0;


    }

    }
}
