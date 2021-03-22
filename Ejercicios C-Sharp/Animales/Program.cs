using System;

namespace Animales
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("--------------- ANIMALES ---------------");
            Console.WriteLine("");
            Console.WriteLine("--------------- MAMIFEROS --------------");
            Perro dog = new Perro("Akita");
            dog.Tipo= "Perro";
            dog.Nombre = "Rocky";
            dog.Patas = 4;
            dog.Edad = 3;
            
            dog.EsDomestico = true;
            Console.WriteLine("El Mamifero es = " + dog.Tipo);
            Console.WriteLine("El Nombre es = " + dog.Nombre);
            Console.WriteLine("La raza del perro es = " + dog.Raza);
            Console.WriteLine("El perro tiene " + dog.Patas + " patas");
            dog.caminar();
            Console.WriteLine("El perro tiene " + dog.Edad + " años");
            dog.Ladrar();
            dog.Tamaño();
            Console.WriteLine("¿El perro es domestico? = " + dog.EsDomestico);

            Console.WriteLine("");
            
            Gato cat = new Gato();
            cat.Tipo = "Gato";
            cat.Nombre = "Michi";
            cat.Patas = 4;
            cat.Edad = 2;
            cat.Domestico = true;
            
            Console.WriteLine("El Mamifero es = " + cat.Tipo);
            Console.WriteLine("El Nombre es = " + cat.Nombre);
            Console.WriteLine("El Gato tiene " + cat.Patas + " patas");
            cat.caminar();
            Console.WriteLine("El Gato tiene " + cat.Edad + " años");
            cat.Maullar();
            cat.Tamaño();
            Console.WriteLine("¿El gato es domestico? = " + cat.Domestico);
            Console.WriteLine("");
    
            Mono kong = new Mono();
            kong.Domestico = false;
            kong.Patas = 2;
            kong.Tipo = "Mono";
            kong.Nombre = "kong";
           
            Console.WriteLine("El Mamifero es = " + kong.Tipo);
            Console.WriteLine("El Nombre es = " + kong.Nombre);
            Console.WriteLine("El mono tiene = " + kong.Patas + " patas");
            kong.caminar();
            Console.WriteLine("El mono es domestico? = " + kong.Domestico);
            kong.comida();
            Console.WriteLine("");

            Console.WriteLine("--------------- AVES --------------");
            Console.WriteLine("");
            
            Aguila Ag = new Aguila();
            Ag.clasedeAve = "Aguila Arpia";
            Ag.ColorPlumas = "Blaco y Gris";
            Ag.Edad = 15;
            Ag.PuedeVolar = true;
            Ag.VuelaAlto = true;
            
            Console.WriteLine("Clase de Ave = " +Ag.clasedeAve);
            Console.WriteLine("Color de plumas del Aguila Arpia = " +Ag.ColorPlumas);
            Console.WriteLine("El aguila arpia tiene " +Ag.Edad + " años");
            Console.WriteLine("¿Puede volar? R= " + Ag.PuedeVolar);
            Ag.Volar();
            Console.WriteLine("¿Vuela alto? R= " + Ag.VuelaAlto);
            Ag.Vision();
            Ag.Presa();
            Console.WriteLine("");

            
            Loro Loro = new Loro();
            Loro.clasedeAve = "Loro Pusio";
            Loro.ColorPlumas = "Verde y gris";
            Loro.Edad = 5;
            Loro.PuedeVolar = true;
            Loro.EsSocialble = true;
            
            Console.WriteLine("Clase de Ave = " +Loro.clasedeAve);
            Console.WriteLine("Color de plumas del Loro = " +Loro.ColorPlumas);
            Console.WriteLine("El Loro tiene " +Loro.Edad + " años");
            Console.WriteLine("¿Puede volar? R= " + Loro.PuedeVolar);
            Loro.Volar();
            Console.WriteLine("¿Es sociable? R= " + Loro.EsSocialble);
            Loro.hablar();
            Loro.alimento();
            Console.WriteLine("");

            Console.WriteLine("--------------- Peces --------------");
            Console.WriteLine("");
        
            PezGlobo Pglob = new PezGlobo();
            Pglob.Nombre = "Pez Globo";
            Pglob.habitad = "Aguas Oceanicas Tropicales";
            Pglob.EsVenenoso = true;
            Pglob.Aletas = 2;
            Console.WriteLine("El Pez se llama: " +Pglob.Nombre);
            Console.WriteLine("El Pez Globo vive en: " + Pglob.habitad);
            Console.WriteLine("El Pez Globo es Venenso? = " + Pglob.EsVenenoso);
            Pglob.Defensa();
        }
    }
}
