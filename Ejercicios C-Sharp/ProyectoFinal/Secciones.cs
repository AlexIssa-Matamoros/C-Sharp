using System;
using System.Collections.Generic;

public class Secciones
{
    public List<Introduccion> ParaIntroduccion { get; set; }

    public Secciones()
    {
        ParaIntroduccion = new List<Introduccion>();
        Introduccion IA1 = new Introduccion(01, 0700, "LuMaMiJue",30,"Bily Fernandez");
        ParaIntroduccion.Add(IA1);
        Introduccion IA2 = new Introduccion(02, 0800, "LuMaMiJue",30,"Bily Fernandez");
        ParaIntroduccion.Add(IA2);
        Introduccion IA3 = new Introduccion(03, 0900, "LuMaMiJue",30,"Bily Fernandez");
        ParaIntroduccion.Add(IA3);
        
    }
    ////////////////////////////////////////////////////////////////////////
    public void SeccionesIntro()
    {
        Console.Clear();
        Console.WriteLine("Secciones");
        Console.WriteLine("");

        foreach (var I in ParaIntroduccion)
        {
            Console.WriteLine(I.Codigo + " - " + I.Seccion + " , " + I.Horario + " , " + I.Cupos + " , " + I.Profesor);
        }
        
        while (true)
        {
            Console.WriteLine("");
            
                Console.WriteLine("Ingrese el codigo de la clase: ");
                string CodigoClase = Console.ReadLine();
                Introduccion intro = ParaIntroduccion.Find(i => i.Codigo.ToString() == CodigoClase);
                if (intro == null)
                {
                    Console.WriteLine("Seccion no encontrado");
                    Console.ReadLine();
                    return;
                } else {
                    Console.WriteLine("Seccion encontrada: " + intro.Seccion + " , " + intro.Horario + " , " + intro.Cupos + " , " + intro.Profesor);
                }
            Console.WriteLine("Desea Matricular la clase en una de estas secciones? s/n");
            string continuar = Console.ReadLine();
            if (continuar.ToLower() == "n")
            {
                break;
            }
                
        }

    }

            
}
