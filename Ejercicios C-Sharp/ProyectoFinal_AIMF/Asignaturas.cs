using System;

public class Asignaturas
{
    public string Clase { get; set; }
    public int Codigo_Clase { get; set; } 

    public Asignaturas(int codigo_clase, string clase)
    {
        Codigo_Clase = codigo_clase;
        Clase = clase;
    }
}