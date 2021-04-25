using System;

public class MenuPrincipal
{
    public void menu()
    {
        MenuSecundario M2 = new MenuSecundario();
        AdicionarAsig Ad = new AdicionarAsig();
        string opcion = "";
        while (true)
        {
            Console.Clear();
            Console.WriteLine("DIRECCION DE INGRESO PERMANECIA Y PROMOCION DIPP - UNAH");
            Console.WriteLine("=======================================================");
            Console.WriteLine("");
            Console.WriteLine("1 - Adicionar asignatura                  |  5 - Ver Departamentos");
            Console.WriteLine("2 - Cancelar asignatura                   |  6 - Ver Asignaturas ");
            Console.WriteLine("3 - Formar 03                             |  7 - Ver Secciones");
            Console.WriteLine("4 - Estado de Cuenta                      |  8 - Ver Clases Matriculadas");
            Console.WriteLine("0 - Cerrar Sesion                         |  9 - Ver Clases Canceladas");
            opcion = Console.ReadLine();
            switch (opcion)
            {
                case "1":
                Ad.MatricularClase();
                    break;
                case "2":
                    Ad.Cancelar();
                    break;
                case "3":
                    Ad.Forma03();
                    break;
                case "4":
                   Ad.PreMatricula();
                    break;
                case "5":
                   Ad.MostrarDepto();
                    break;
                case "6":
                    Ad.MostrarAsig();
                    break;
                case "7":
                    Ad.MostrarSecc();
                    break;
                case "8":
                     Ad.PreMatricula();
                    break;
                case "9":
                    //Ad.AsigCanceladas();
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