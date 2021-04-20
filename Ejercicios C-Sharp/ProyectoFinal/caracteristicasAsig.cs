using System;
using System.Collections.Generic;

public class Asig
{
    public string Clase { get; set; }
    public int Codigo { get; set; }
    public string Numero { get; set; }
    
    
    public Asig(string numero, int codigo,string clase)
    {
        Clase = clase;
        Codigo = codigo; 
        Numero = numero;
    }

}