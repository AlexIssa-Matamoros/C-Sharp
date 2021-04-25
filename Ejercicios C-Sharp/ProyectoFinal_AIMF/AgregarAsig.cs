using System;
using System.Collections.Generic;

public class AgregarAsig
{
public int Nmatricula { get; set; }
public int Mmatricula { get; set; }
public Alumno Alumno { get; set; }
public Departamentos Departamentos { get; set; }
public Secciones Secciones { get; set; }
public Asignaturas Asignaturas { get; set; }

public string SeccionesM { get; set; }
// Para mostrarlas en la PreMatricula
public string SeccionesC { get; set; }
public string CodigoClase { get; set; }
public string ParaNombre { get; set; }
public int ParaSecciones { get; set; } 
public string ParaHorario { get; set; }
public int HoraIni { get; set; }
public int Horafi { get; set; }
public string Edi { get; set; }

public List<ListadoMatricula> Matriculado { get; set; }
public List<ListadoMatricula> Canc { get; set; }


   public AgregarAsig(Departamentos departamentos, Asignaturas asignaturas, Alumno alumno)
    {
       //Mmatricula = mmatricula;
      // Nmatricula = nmatricula;
       Departamentos = departamentos;
       Asignaturas = asignaturas;
       Alumno = alumno;
       Matriculado = new List<ListadoMatricula>();
       Canc = new List<ListadoMatricula>();
    }
    public void AgragarAsignatura(Asignaturas asignaturas, Secciones secciones, Alumno alumno)
    {
        //int Nmatricula = Matriculado.Count + 1;

        ListadoMatricula Lm = new ListadoMatricula(asignaturas,secciones,alumno);
        Matriculado.Add(Lm);
        SeccionesM = asignaturas.Codigo_Clase + " , " + asignaturas.Clase + " , " + secciones.Seccion + " , " + secciones.Horario + " , " + secciones.Cupos + " , " + secciones.Profesor;
        
      
        CodigoClase = asignaturas.Codigo_Clase;
        ParaNombre = asignaturas.Clase;
        ParaSecciones = secciones.Seccion;
        ParaHorario = secciones.Horario;
        HoraIni = secciones.HI;
        Horafi = secciones.HF;
        Edi = secciones.Edificio;

    }
    
    public void Cancelarsignatura(Asignaturas asignaturas, Secciones secciones, Alumno alumno)
    {
        //int Nmatricula = Matriculado.Count + 1;

        ListadoMatricula A = new ListadoMatricula(asignaturas,secciones,alumno);
        Canc.Add(A);
        SeccionesM = asignaturas.Codigo_Clase + " , " + asignaturas.Clase + " , " + secciones.Seccion + " , " + secciones.Horario + " , " + secciones.Cupos + " , " + secciones.Profesor;
        
      
        CodigoClase = asignaturas.Codigo_Clase;
        ParaNombre = asignaturas.Clase;
        ParaSecciones = secciones.Seccion;
        ParaHorario = secciones.Horario;
        HoraIni = secciones.HI;
        Horafi = secciones.HF;
        Edi = secciones.Edificio;

        

    }
    
}
    