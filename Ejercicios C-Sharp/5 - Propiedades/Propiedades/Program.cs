using System;

namespace propiedades
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno a = new Alumno();
            a.PrimerNombre = "Juan";
            a.SegundoNombre = "Perez";

            Console.WriteLine(a.PrimerNombre);
        }
    }
}