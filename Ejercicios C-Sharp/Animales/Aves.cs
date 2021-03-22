using System;

    public abstract class Aves: Animal
    {
        public bool PuedeVolar { get; set; } // Ay aves que no vuelan como otras
        public bool Domestico { get; set; } // hay aves que las toman como domesticas
        public string clasedeAve { get; set; }
        public string ColorPlumas { get; set; }
    }