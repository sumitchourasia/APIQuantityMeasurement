using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityUnits.WeightUnits
{
    public class KiloGrams
    {
        double kilogram = 0.0;

        public KiloGrams(double kilogram)
        {
            this.kilogram = kilogram;
        }

        public double Convert(KiloGrams kilogramsObject)
        {
            return this.kilogram;
        }

        public double Convert(Grams gramsObject)
        {
            return this.kilogram * 1000;
        }
    }
}
