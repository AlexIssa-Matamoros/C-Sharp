using System;

    public class Mono: Mamifero
    {
        public bool Domestico { get; set; }
        
        public void comida()
        {
            Console.WriteLine("El mono come Bananas");
        }
    }