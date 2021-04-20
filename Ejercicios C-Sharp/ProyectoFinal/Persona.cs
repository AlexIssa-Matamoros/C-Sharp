using System;

    public class Persona
{
    public int N_Cuenta { get; set; }
    public string Nombre { get; set; }
    public string Contraseña { get; set; }

    public Persona(int ncuenta, string nombre, string contraseña)
    {
        N_Cuenta = ncuenta;
        Nombre = nombre;
        Contraseña = contraseña;
    }


}