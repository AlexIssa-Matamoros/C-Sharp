using System;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
          
            

            alumno a = new alumno();
            a.codigo = 11;
            a.Nombre = "Issa";
            a.NoCuenta ="20192001";

            profesor f = new profesor();
            f.codigo = 1;
            f.Nombre = "Bily";
            f.telefono = "3434564";
            f.salario = 122321;
        }
    }
}
