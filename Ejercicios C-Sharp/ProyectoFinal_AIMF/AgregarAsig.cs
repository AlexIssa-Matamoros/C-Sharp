using System;
using System.Collections.Generic;

public class AgregarAsig
{
public int Nmatricula { get; set; }
public Alumno Alumno { get; set; }
public Departamentos Departamentos { get; set; }
public Secciones Secciones { get; set; }
public Asignaturas Asignaturas { get; set; }

public string SeccionesM { get; set; }
public List<ListadoMatricula> Matriculado { get; set; }

   public AgregarAsig(int nmatricula,Departamentos departamentos, Asignaturas asignaturas, Alumno alumno)
    {
       
       Nmatricula = nmatricula;
       Departamentos = departamentos;
       Asignaturas = asignaturas;
       Alumno = alumno;
       Matriculado = new List<ListadoMatricula>();
    }
    public void AgragarAsignatura(Asignaturas asignaturas, Secciones secciones, Alumno alumno)
    {
        int Nmatricula = Matriculado.Count + 1;

        ListadoMatricula Lm = new ListadoMatricula(Nmatricula,asignaturas,secciones);
        Matriculado.Add(Lm);
        SeccionesM = asignaturas.Codigo_Clase + " , " + asignaturas.Clase + " , " + secciones.Seccion + " , " + secciones.Horario + " , " + secciones.Cupos + " , " + secciones.Profesor;
        
    }
    
}
    