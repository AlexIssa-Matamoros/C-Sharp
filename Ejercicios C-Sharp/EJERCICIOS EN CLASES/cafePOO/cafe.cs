using System;

namespace cafePOO{
    class cafe {
        public bool Vacio { get; set; }
        private int  capacidad = 5;
        public  void Rellenar()
        {

            capacidad = 5;
            Vacio = false;
        }

         public void Beber()
        {

        {
            capacidad --;
    
            if (capacidad <= 0)
                Console.WriteLine("Se acabo el cafe mirey");
            }
        }
    }


}
