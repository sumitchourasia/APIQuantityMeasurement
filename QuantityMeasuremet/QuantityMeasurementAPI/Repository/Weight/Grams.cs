using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Weight
{
    public class Grams
    {
        double grams = 0.0;

        public Grams(double grams)
        {
            this.grams = grams;
        }

        public double Convert(Grams grams)
        {
            return this.grams;
        }

        public double Convert(KiloGrams kilogramsObject)
        {
            return this.grams / 1000;
        }
    }
}

