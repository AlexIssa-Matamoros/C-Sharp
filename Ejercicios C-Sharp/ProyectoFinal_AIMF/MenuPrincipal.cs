using System;

public class MenuPrincipal
{
    public void menu()
    {
        VerAsignaturas VA = new VerAsignaturas();
        string opcion = "";
        while (true)
        {
            Console.Clear();
            Console.WriteLine("DIRECCION DE INGRESO PERMANECIA Y PROMOCION DIPP - UNAH");
            Console.WriteLine("=======================================================");
            Console.WriteLine("");
            Console.WriteLine("1 - Ver Asignaturas del Departamento de Informatica");
            Console.WriteLine("2 - Adicionar asignatura");
            Console.WriteLine("3 - Cancelar asignatura");
            Console.WriteLine("4 - Listado de asignaturas canceladas");
            Console.WriteLine("5 - Forma 03");
            Console.WriteLine("6 - Estao de cuenta");
            Console.WriteLine("0 - Cerrar Sesion");

            opcion = Console.ReadLine();
            switch (opcion)
            {
                case "1":
                   VA.Intro();
                   Console.WriteLine("Taller");
                   VA.Taller();
                    break;
                case "2":
                    
                    break;
                case "3":
                    
                    break;
                case "4":
                   
                    break;
                case "5":
                   
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