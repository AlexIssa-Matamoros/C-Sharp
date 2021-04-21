using System;

public class Alumno:Persona
{
    
    public string contra { get; set; }

    public Alumno(int numerocuenta, string nombre)
    {
        NumeroCuenta = numerocuenta;
        Nombre = nombre;
    }
}