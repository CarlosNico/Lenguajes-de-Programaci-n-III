using System;
namespace Ejercicio1
{
    class UMI
    {
        static void Main(string[] args)
        {
            //definir variables
            string nombre;
            int edad;
            DateOnly fechanacimiento;
            string carrera;
            
            
            Console.WriteLine("\nIngrese su nombre completo: ");
            nombre = Console.ReadLine();

            Console.WriteLine("\nIngrese edad: ");
            edad = int.Parse(Console.ReadLine());

            Console.WriteLine("\nIngrese su fecha de nacimiento (DD-MM-AA): ");
            fechanacimiento = DateOnly.Parse(Console.ReadLine());

            Console.WriteLine("\nIngrese su carrera: ");
            carrera = Console.ReadLine();

            Console.WriteLine("\n\n--------------------------------------------------------------------------------------");
            Console.WriteLine("\n\nGracias " + nombre + " por formar parte de UMI/Universidad Coppel, Bienvenido a la carrera " + carrera);

            Console.WriteLine("\n\nNombre Completo: " + nombre);
            Console.WriteLine("\nEdad: " + edad);
            Console.WriteLine("\nFecha de Nacimiento: " + fechanacimiento);
            Console.WriteLine("\nCarrera que Cursa: " + carrera);
            Console.WriteLine("\n");

        }
    }

}