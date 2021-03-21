using System;

public class PezGlobo: Peces
{
    public bool EsVenenoso { get; set; }

    public PezGlobo()
    {
        EsVenenoso = true;
    }
    public PezGlobo(bool esvenenoso)
    {
        EsVenenoso = esvenenoso;
    }

    public void Defensa()
    {
        Inflarse();
    }

    private void Inflarse()
    {
        Console.WriteLine("EL pez Globo se infla cuando son atacados o se asustan");
    }

}