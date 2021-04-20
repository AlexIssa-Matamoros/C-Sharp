using System;

public class Introduccion: detalles
{
    public int Codigo { get; set; }

    public Introduccion(int codigo, int seccion, string horario, int cupos, string profesor)   
    {
        Codigo = codigo;
        Seccion = seccion;
        Horario = horario;
        Cupos = cupos;
        Profesor = profesor;
    }
}