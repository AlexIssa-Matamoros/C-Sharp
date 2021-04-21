using System;

public class Alumno:Persona
{
    
    public string contra { get; set; }

    public Alumno(long numerocuenta, string nombre)
    {
        NumeroCuenta = numerocuenta;
        Nombre = nombre;
    }
}