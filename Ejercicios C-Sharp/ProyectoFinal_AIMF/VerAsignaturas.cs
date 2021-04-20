using System;
using System.Collections.Generic;

public class VerAsignaturas
{

    public List<Informatica> ListadeIntroduccion { get; set; }
    public List<Informatica> ListadeTaller { get; set; }


    public VerAsignaturas()
    {
        ListadeIntroduccion = new List<Informatica>();
        Informatica A1 = new Informatica("01)", "Introduccion a Informatica", 0700, "LuMaMiJue",30,"Bily Fernandez");
        ListadeIntroduccion.Add(A1);
        Informatica A2 = new Informatica("02)", "Introduccion a Informatica", 0710, "LuMaMiJue",30,"Bily Fernandez");
        ListadeIntroduccion.Add(A2);
        Informatica A3 = new Informatica("03)", "Introduccion a Informatica", 0800, "LuMaMiJue",30,"Bily Fernandez");
        ListadeIntroduccion.Add(A3);
        Informatica A4 = new Informatica("04)", "Introduccion a Informatica", 0810, "LuMaMiJue",30,"Bily Fernandez");
        ListadeIntroduccion.Add(A4);
        Informatica A5 = new Informatica("05)", "Introduccion a Informatica", 0900, "LuMaMiJue",30,"Bily Fernandez");
        ListadeIntroduccion.Add(A5);

        ListadeTaller = new List<Informatica>();
        Informatica T1 = new Informatica("01)", "Taller de Hardware 1", 0700, "LuMaMiJue",30,"Bily Fernandez");
        ListadeTaller.Add(T1);
        Informatica T2 = new Informatica("02)", "Taller de Hardware 1", 0700, "LuMaMiJue",30,"Bily Fernandez");
        ListadeTaller.Add(T2);
        Informatica T3 = new Informatica("03)", "Taller de Hardware 1", 0700, "LuMaMiJue",30,"Bily Fernandez");
        ListadeTaller.Add(T3);
        Informatica T4 = new Informatica("04)", "Taller de Hardware 1", 0700, "LuMaMiJue",30,"Bily Fernandez");
        ListadeTaller.Add(T4);
        Informatica T5 = new Informatica("05)", "Taller de Hardware 1", 0700, "LuMaMiJue",30,"Bily Fernandez");
        ListadeTaller.Add(T5);

    }
public void VerClasesDisponibles()
{
    
}
    public void Intro()
    {
        Console.Clear();
        Console.WriteLine("Asignaturas y Secciones");
        Console.WriteLine("");
        Console.WriteLine("             Asignatura           |Secc | Horarios  | Cupos | Profesor");
        foreach (var In in ListadeIntroduccion)
        {
            Console.WriteLine(In.Codigo + " | " + In.Clase + "  | " + In.Seccion + " | " + In.Horario + " | " + In.Cupos + "    | " + In.Profesor);
        } 
    
        Console.ReadLine();
    }

    public void Taller()
    {
        foreach (var Ta in ListadeTaller)
        {
            Console.WriteLine(Ta.Codigo + " | " + Ta.Clase + "        | " + Ta.Seccion + " | " + Ta.Horario + " | " + Ta.Cupos + "    | " + Ta.Profesor);
        }
        Console.ReadLine();
    }

   
}