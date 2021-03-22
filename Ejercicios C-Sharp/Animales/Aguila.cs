using System;

    public class Aguila: Aves // Herencia
    {
        public bool VuelaAlto { get; set; }
        public string tipodeAguila { get; set; }

    public Aguila() // Polimorfismo
    {
        VuelaAlto = true;
    }

    public Aguila(bool vuelaAlto) // Polimorfismo
    {
        VuelaAlto = vuelaAlto;
    }

    public void Vision()  //Abstraccion
    {
        Console.WriteLine("El Aguila posee una vista muy aguda que les permite visualizar facilmente a sus presas");
    }

    public void Presa()
    {
        PresadeAguila();
    }
    private void PresadeAguila() //Encapsulamiento
    {
        Console.WriteLine("La presa de las aguilas suelen ser pequeños y medianos mamiferos");
    }















}