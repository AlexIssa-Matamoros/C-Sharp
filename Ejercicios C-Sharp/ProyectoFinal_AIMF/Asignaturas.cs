using System;

public class Asignaturas
{
    public string Clase { get; set; }
    public int Codigo_Clase { get; set; } 

    public Asignaturas(int codigo_clase)
    {
        Codigo_Clase = codigo_clase;
    }
}