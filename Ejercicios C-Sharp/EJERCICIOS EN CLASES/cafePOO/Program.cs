using System;

namespace cafePOO
{
    class Program
    {
        static void Main(string[] args)
        {
            String opcion = "";
            cafe cafe = new cafe();
            
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Desea beber cafe? s/n");
                opcion= Console.ReadLine();
                
                if (opcion == "s")
                {
                    cafe.Beber();
                }
            
            }
        }
    }
}
