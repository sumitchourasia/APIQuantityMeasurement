using System;
using System.Collections.Generic;
using System.Text;

namespace Model.LengthModel
{
    public class Feet
    {
        public double feet = 0.0;

        public Feet(double valueToConvert)
        {
            this.feet = valueToConvert;
        }

        public double Convert(Feet feetObject)
        {
            return this.feet ;
        }

        public double Convert(Inch inchObject)
        {
            return this.feet * 12;
        }

        public double Convert(Yard yardObject)
        {
            return this.feet/3;
        }
    }
}
