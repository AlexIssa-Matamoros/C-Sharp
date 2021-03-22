using System;

    public class Mono: Mamifero //Herencia
    {
        public bool Domestico { get; set; }
        
        public void comida() 
        {
            Console.WriteLine("El mono come Bananas");
        }
    }