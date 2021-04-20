using System;
using System.Collections.Generic;
public class Asignaturas
{
      public List<Asig> ListadeAsignaturas { get; set; }

    

     public Asignaturas()
     {
         ListadeAsignaturas = new List<Asig>();
         MostrarAsignaturas();
     }

    private void MostrarAsignaturas()
    {
        Asig A1 = new Asig(003,"Introduccion a la Informatica");
        ListadeAsignaturas.Add(A1);
        
        Asig A2 = new Asig(013,"Taller de Hardware 1");
        ListadeAsignaturas.Add(A2);

        Asig A3 = new Asig(023,"Metodologia de la programacion");
        ListadeAsignaturas.Add(A3);

        Asig A4 = new Asig(033,"Lenguaje de Programacion I");
        ListadeAsignaturas.Add(A4);

        Asig A5 = new Asig(043,"Sistemas Operativos 1");
        ListadeAsignaturas.Add(A5);
    }

    public void ListarAsignaturas()
    {
        Console.Clear();
        Console.WriteLine("ASIGNATURAS");
        Console.WriteLine("___________");
        Console.WriteLine("");

        foreach (var As in ListadeAsignaturas)
        {
            Console.WriteLine(As.Codigo + "-" + As.Clase);
        }
        while (true)
        {
            op = Console.ReadLine();
            switch (op)
            {
                case "1":
                    Secc.SeccionesIntro();
                    break;
                case "2":
                    Secc.SeccionesIntro();
                    break;
                case "3":
                    Secc.SeccionesIntro();
                    break;
                case "4":
                    Secc.SeccionesIntro();
                    break;
                case "5":
                    Secc.SeccionesIntro();
                    break;
            }
                if (op.ToLower() == "0")
                {
                    break;
                }
        }
       
        
    }

}








  
