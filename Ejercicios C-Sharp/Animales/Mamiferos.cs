using System;

public abstract class Mamifero: Animal //Herencia
{
    public int Patas { get; set; }
    public int Alas { get; set; } // En caso de que el mamifero sea un murcielago
    public int Aletas { get; set; } // En caso de que el mamifero sea un ballena

    public bool EsDomestico { get; set; }

}
