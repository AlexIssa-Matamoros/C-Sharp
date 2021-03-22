using System;

    public class Aguila: Aves
    {
        public bool VuelaAlto { get; set; }
        public string tipodeAguila { get; set; }

    public Aguila()
    {
        VuelaAlto = true;
    }

    public Aguila(bool vuelaAlto)
    {
        VuelaAlto = vuelaAlto;
    }

    public void Vision()
    {
        Console.WriteLine("El Aguila posee una vista muy aguada que les permite visualizar facilmente a sus presas");
    }

    public void Presa()
    {
        PresadeAguila();
    }
    private void PresadeAguila()
    {
        Console.WriteLine("La presa de las aguilas suelen ser pequeños y medianos mamiferos");
    }















}