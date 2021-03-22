using System;

public class PezGlobo: Peces //Herencia
{
    public bool EsVenenoso { get; set; }

    public PezGlobo() //Polimorfismo
    {
        EsVenenoso = true;
    }
    public PezGlobo(bool esvenenoso) //Polimorfismo
    {
        EsVenenoso = esvenenoso;
    }

    public void Defensa()
    {
        Inflarse();
    }

    private void Inflarse() //Encapsulamiento
    {
        Console.WriteLine("EL pez Globo se infla cuando son atacados o se asustan");
    }

}