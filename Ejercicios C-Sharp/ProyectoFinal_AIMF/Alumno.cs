using System;

public class Alumno:Persona
{
    
    public int Contra { get; set; }

    public Alumno(long numerocuenta, string nombre,int contra )
    {
        NumeroCuenta = numerocuenta;
        Nombre = nombre;
        Contra = contra;
    }


    
}