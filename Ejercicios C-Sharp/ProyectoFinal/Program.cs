using System;

namespace ProyectoFinal
{
    class Program
    {
        static void Main(string[] args)
        { 
          Matricula matri = new Matricula();
          Adiciones adi = new Adiciones();
          string opcion = "";
          
         while (true)
         {
            Console.Clear();
            Console.WriteLine("DIRECCION DE INGRESO PERMANECIA Y PROMOCION DIPP - UNAH");
            Console.WriteLine("=======================================================");
            Console.WriteLine("");
            Console.WriteLine("1 - Adicionar Asignatura");
            Console.WriteLine("2 - Cancelar asignatura");
            Console.WriteLine("3 - Listado de asignaturas canceladas");
            Console.WriteLine("4 - Forma 03");
            Console.WriteLine("5 - Estao de cuenta");
            Console.WriteLine("0 - Salir");
            
            opcion = Console.ReadLine();
            switch (opcion)
            {
                case "1":
                    adi.DEPART();
                    break;
                case "2":
                    matri.Listarclases();
                    break;
                case "3":
                    matri.Listarclases();
                    break;
                case "4":
                    matri.Listarclases();
                    break;
                case "5":
                    matri.Listarclases();
                    break;
                default:
                break;
            }

            if (opcion == "0")
            {
                break;
            }

         }
              

        }
    }
}
