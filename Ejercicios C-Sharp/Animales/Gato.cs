using System;

public class Gato: Mamifero //Herencia
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

    public Gato(bool esDomestico) //Polimorfismo
    {
        Domestico = esDomestico;
    }

    public void Maullar() //Abstraccion
    {
        Console.WriteLine("El gato le hace MIAU... MIAU...");
    }

    public void Tamaño()
    {
        GatoPequeño();
    }

    private void GatoPequeño() //Encapsulamiento
    {
        Console.WriteLine("El Gato es mediano");
    }
}