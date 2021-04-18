using System;
using System.Collections.Generic;

public class Asignatura
{
    public string Clase { get; set; }
    public int Seccion { get; set; }
    public string Horario { get; set; }
    public int Cupos { get; set; }
    public string Profesor { get; set; }

    public Asignatura(string clase, int seccion, string horario, int cupos, string profesor)
    {
        Clase = clase;
        Seccion = seccion;
        Horario = horario;
        Cupos = cupos;
        Profesor = profesor;
    }

}