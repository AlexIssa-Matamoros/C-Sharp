using System;
using System.Collections.Generic;

public class Matricula:Adiciones
{
    public List<Asignatura> ListadeAsignatura { get; set; }

    public Matricula()
    {
        ListadeAsignatura = new List<Asignatura>();
        
        Asignatura a = new Asignatura("Introduccion a Informatica     |", 0700, "| LuMaMiJu |", 30, "| Profe: Bily Fernandez");
        Asignatura b = new Asignatura("Metodologia de la Programacion |", 0800, "| LuMaMiJu |", 30, "| Profe: Bily Fernandez");
        Asignatura c = new Asignatura("L1                             |", 0900, "| LuMaMiJu |", 30, "| Profe: Bily Fernandez");
        Asignatura d = new Asignatura("Sistemas Operativos 1          |", 1000, "| LuMaMiJu |", 30, "| Profe: Bily Fernandez");
        Asignatura e = new Asignatura("Taller de Hardware 1           |", 1200, "| LuMaMiJu |", 30, "| Profe: Bily Fernandez");

        ListadeAsignatura.Add(a);
        ListadeAsignatura.Add(b);
        ListadeAsignatura.Add(c);
        ListadeAsignatura.Add(d);
        ListadeAsignatura.Add(e);
    }

    public void Listarclases()
    {
        Console.Clear();
        Console.WriteLine("");
        Console.WriteLine("ASIGNATURAS");
        Console.WriteLine("************");
            
            Console.WriteLine("    Nombre de la asignatura    |Seccion| Horarios |Cupos|       Profesor      |");
            Console.WriteLine("_______________________________________________________________________________");

        foreach (var clases in ListadeAsignatura)
        {
            Console.WriteLine(clases.Clase + "  " + clases.Seccion + "  " + clases.Horario + "  " + clases.Cupos + " " + clases.Profesor);        
        }
        Console.WriteLine("");
        Console.WriteLine("0 - ATRAS");
        
    }
    private void retorno()
    {
        Adiciones adi = new Adiciones();
        string opcion = "";
        if (opcion == "0")
            {
                adi.DEPART();
            }
    }

}