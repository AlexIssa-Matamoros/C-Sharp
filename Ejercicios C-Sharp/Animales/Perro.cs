using System;
public class Perro: Mamifero
{
    public bool EsDomestico { get; set; }
    public string Raza { get; set; }

    public Perro()
    {
        EsDomestico = true;
    }

    public Perro(bool esDomestico)
    {
        EsDomestico = esDomestico;
    }

    public void Ladrar()
    {
        Console.WriteLine("GUAU GUAU GUAU");
    }

    public void Tamaño()
    {
        PerroGrande();
    }

    private void PerroGrande()
    {
        Console.WriteLine("El perro es grande");
    }

    public Perro(string raza)
    {
        Raza=raza;
    }
}