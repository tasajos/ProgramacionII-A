using programacion2.Clase01;

namespace programacion2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            funcionesMetodos.SALUDAR2();
            Console.WriteLine("Por favor dinos tu nombre");
            string nombre = Console.ReadLine();
            Console.WriteLine("Bienvenido " +  nombre);
            Console.WriteLine("por favor dinos en que semestre estas");
            string semestre = Console.ReadLine();
            Console.WriteLine("Vamos a interactuar contigo y realizar funciones y metodos");
            Console.WriteLine("por favor ingresa un numero para A");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("por favor ingresa un numero para B");
            int b = int.Parse(Console.ReadLine());

            /*
            int suma;
            suma = a + b;
            Console.WriteLine("el resultado es " + suma);
            */
            Console.WriteLine("La suma es " + funcionesMetodos.sumarf(a,b));
            Console.WriteLine("La multiplicacion es " + funcionesMetodos.multiplicacionf(a,b));
            Console.WriteLine("La resta es " + funcionesMetodos.restarf(a, b));
        }
    }
}