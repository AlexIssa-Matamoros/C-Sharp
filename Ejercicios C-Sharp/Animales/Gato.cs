using System;

public class Gato: Mamifero
{
    public bool Domestico { get; set; }
    public string Color { get; set; }

    public Gato(string color)
    {
        Color = color;
    }
    public Gato()
    {
        Domestico = true;
    }

    public Gato(bool esDomestico)
    {
        Domestico = esDomestico;
    }

    public void Maullar()
    {
        Console.WriteLine("MIAU... MIAU...");
    }

    public void Tamaño()
    {
        GatoPequeño();
    }

    private void GatoPequeño()
    {
        Console.WriteLine("El Gato es grande");
    }
}