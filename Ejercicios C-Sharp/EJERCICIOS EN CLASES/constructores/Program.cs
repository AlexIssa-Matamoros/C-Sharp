using System;

namespace Constructores
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno a = new Alumno();
            a.Id = 1;
            a.Nombre = "Juan";


            Console.WriteLine(a.Nombre);
        }
    }
}
