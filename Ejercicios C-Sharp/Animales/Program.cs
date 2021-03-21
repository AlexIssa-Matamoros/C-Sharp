using System;

namespace Animales
{
    class Program
    {
        static void Main(string[] args)
        {
            PezGlobo Pglob = new PezGlobo();
            Pglob.Defensa();
            Pglob.Nombre = "Pez Globo";
            Pglob.habitad = "Agua Salada";
            Pglob.EsVenenoso = true;
            Pglob.Aletas = 2;
            Console.WriteLine("El Pez se llama: " +Pglob.Nombre);
            Console.WriteLine("El Pez Globo vive en: " + Pglob.habitad);
            Console.WriteLine("El Pez Globo es Venenso? = " + Pglob.EsVenenoso);
        

           Perro dog = new Perro("Akita");
           dog.Ladrar();
           dog.Tamaño();
           dog.Nombre = "Rocky";
           dog.Patas = 3;
           dog.EsDomestico = true;

           Console.WriteLine("El perro se llama: " + dog.Nombre);
           Console.WriteLine("El Perro tiene " +dog.Patas+  " patas");
           Console.WriteLine("El Perro es de raza: " +dog.Raza);
           Console.WriteLine("El Perro es Domestico? "  + dog.EsDomestico);
           Console.WriteLine("");

           Perro can = new Perro("Labrador");
           can.Ladrar();
           can.Tamaño();
           can.Nombre = "Baxter";
           can.Patas = 4;
           can.EsDomestico = true;
           

           Console.WriteLine("El perro se llama: " + can.Nombre);
           Console.WriteLine("El Perro tiene " +can.Patas+  " patas");
           Console.WriteLine("El Perro es de raza: " +can.Raza);
           Console.WriteLine("El Perro es Domestico? "  + can.EsDomestico);
           Console.WriteLine("");

           Gato cat = new Gato("Blanco con negro");
           cat.Nombre = "Michi";
           cat.Edad = 3;
           cat.Domestico = true;
           cat.Maullar();

        Console.WriteLine("El Gato se llama: " + cat.Nombre);
        Console.WriteLine("El Gato es de color: " + cat.Color);
        Console.WriteLine("El Gato tiene " +cat.Edad+  " años");
        Console.WriteLine("El Gato es Domestico? "  + cat.Domestico);
        Console.WriteLine("");

        Mono kong = new Mono();
        kong.Domestico = false;
        kong.Patas = 2;
        kong.comida();
        kong.Nombre = "Kong";
           
        Console.WriteLine("El mono es domestico? = " + kong.Domestico);
        Console.WriteLine("El mono tiene " + kong.Patas + "patas");
        Console.WriteLine("El mono de llama" + kong.Nombre);
        Console.WriteLine("");








        }
    }
}
