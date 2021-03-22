using System;

    public abstract class Aves: Animal
    {
        public bool PuedeVolar { get; set; }
        public bool Domestico { get; set; }
        public string clasedeAve { get; set; }
        public string ColorPlumas { get; set; }
    }