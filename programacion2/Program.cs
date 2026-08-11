namespace programacion2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*

            Console.WriteLine("UNICEN");
            Console.WriteLine("UNICEN bienvenidos al nuevo mundo");
            Console.Write("PROGRAMACION II");
            */

            saludar();
            Console.WriteLine("Por favor dinos tu nombre");
            string nombre = Console.ReadLine();
            Console.WriteLine("Bienvenido " +  nombre);
            Console.WriteLine("Bienvenido a la carrera de IA");
            Console.WriteLine("por favor dinos en que semestre estas");
            string carrera = Console.ReadLine();
            Console.WriteLine("Vamos a interactuar contigo y realizar funciones y metodos");
            Console.WriteLine("por favor ingresa un numero para A");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("por favor ingresa un numero para B");
            int b = int.Parse(Console.ReadLine());

            int suma;

            suma = a + b;
            
            Console.WriteLine("el resultado es " + suma);

            static void saludar()
            {
                Console.WriteLine("UNICEN bienvenidos al nuevo mundo este es un metodo");
                Console.Write("PROGRAMACION II - rules");
            }


        }
    }
}