using System;

public class Secciones
{
    public int Seccion { get; set; }
    public string Profesor { get; set; }
    public string Horario { get; set; }

    public Secciones(int seccion, string horario, string profesor)
    {
        Seccion = seccion;
        Profesor = profesor;
        Horario = horario;
    }
}