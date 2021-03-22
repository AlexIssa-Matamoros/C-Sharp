using System;
namespace Animales
{
       public class Loro: Aves
    {
        public bool EsSocialble { get; set; }
        public void alimento() // ---- abstraccion
        {
            Console.WriteLine("El loro se alimenta de semillas");
        }

        public void hablar()
        {
            Console.WriteLine("El loro puede hablar");
        }
        public Loro() // Polimorfismo
        {
            EsSocialble = true;
        }

        public Loro(bool esSociable)
        {
            EsSocialble = esSociable;
        }

    }
}
 