using System;
using System.Collections.Generic;

public class AgregarAsig
{
    
public Alumno Alumno { get; set; }
public Departamentos Departamentos { get; set; }
public string Asigna { get; set; }
public int Sec { get; set; }
public List<ListadoMatricula> Matriculado { get; set; }

   public AgregarAsig(Alumno alumno, Departamentos departamentos, string asigna, int sec )
    {
       Alumno = alumno;
       Departamentos = departamentos;
       Asigna = asigna;
       Sec = sec;
       Matriculado = new List<ListadoMatricula>();
    }
    public void AgragarAsignatura(Secciones secciones, Asignaturas asignaturas)
    {
        int Nmatricula = Matriculado.Count + 1;

        ListadoMatricula Lm = new ListadoMatricula(Nmatricula,asignaturas,secciones);
        Matriculado.Add(Lm);
    }
    
}
    