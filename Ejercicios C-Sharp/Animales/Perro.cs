using System;
public class Perro: Mamifero // Herencia
{
    public string Raza { get; set; }

    public Perro() //Poliformismo
    {
        EsDomestico = true;
    }

    public Perro(bool esDomestico) //Poliformismo
    {
        EsDomestico = esDomestico;
    }

    public void Ladrar() //Abstraccion
    {
        Console.WriteLine("El perro le hace = GUAU GUAU GUAU");
    }

    public void Tamaño()
    {
        PerroGrande();
    }

    private void PerroGrande() //Encapsulamiento
    {
        Console.WriteLine("El perro es grande");
    }

    public Perro(string raza) //Contructor
    {
        Raza=raza;
    }
}