using System;

public class MenuSecundario
{
    public void menu2()
    {
        AdicionarAsig VA = new AdicionarAsig();
        string opcion = "";
        while (true)
        {
            Console.Clear();
            Console.WriteLine("DIRECCION DE INGRESO PERMANECIA Y PROMOCION DIPP - UNAH");
            Console.WriteLine("=======================================================");
            Console.WriteLine("");
            Console.WriteLine("1 - Ver Departamentos");
            Console.WriteLine("2 - Ver Asignaturas");
            Console.WriteLine("3 - Ver Secciones");
            Console.WriteLine("4 - Realizar Matricula");
            Console.WriteLine("5 - Ver Clases Matriculadas");
            Console.WriteLine("0 - Atras");

            opcion = Console.ReadLine();
            switch (opcion)
            {
                case "1":
                    VA.MostrarDepto();
                    break;
                case "2":
                    VA.MostrarAsig();
                    break;
                case "3":
                    VA.MostrarSecc();
                    break;
                case "4":
                    VA.MatricularClase();
                    break;
                case "5":
                   VA.PreMatricula();
                    break;
                default:
                break;
            }
            
            if (opcion.ToLower() == "0")
                {
                    break;
                }
        }
        
    }






}