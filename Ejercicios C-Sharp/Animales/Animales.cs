using System;

public  class Animal
{
    public string Nombre { get; set; }
    public int Edad { get; set; }

    public void caminar()
    {
        Console.WriteLine("Puede Caminar...");
    }
    public void Nadar()
    {
        Console.WriteLine("Puede nadar...");
    }
    public void Volar()
    {
        Console.WriteLine("Puede volar...");
    }
}
