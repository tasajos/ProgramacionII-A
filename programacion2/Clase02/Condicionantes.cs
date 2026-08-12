using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programacion2.Clase02
{
    public class Condicionantes
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===============================");
            Console.WriteLine("||===========================||");
            Console.WriteLine("||===========================||");
            Console.WriteLine("||==B==I==E==N=V=E=N=I=D=O=S=||");
            Console.WriteLine("||===========================||");
            Console.WriteLine("||===========================||");
            Console.WriteLine("||=====C==L==A==S=E====2=====||");
            Console.WriteLine("===============================");


            funciones_metodos.SALUDAR();
            //funciones_metodos.datosentrada();
            var (a, b) = funciones_metodos.datosentrada();
            funciones_metodos.validacion(a, b);

        }


       
    }
}
