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
            Console.WriteLine("1 - Adicionar asignatura");
            Console.WriteLine("2 - Cancelar asignatura");
            Console.WriteLine("3 - Listado de asignaturas canceladas");
            Console.WriteLine("4 - Forma 03");
            Console.WriteLine("5 - Estado de cuenta");
            Console.WriteLine("0 - Cerrar Sesion");

            opcion = Console.ReadLine();
            switch (opcion)
            {
                case "1":
                M2.menu2();
                    break;
                case "2":
                    Ad.MostrarSecc();
                    break;
                case "3":
                    
                    break;
                case "4":
                   Ad.PreMatricula();
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