using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityUnits.LengthUnits
{
    public class Yard
    {
        public double yard = 0.0;

        public Yard(double valueToConvert)
        {
            this.yard = valueToConvert;
        }

        public double Convert(Yard yard)
        {
            return this.yard;
        }

        public double Convert(Feet feetObject)
        {
            return this.yard * 3;
        }

        public double Convert(Inch inchObject)
        {
            return this.yard * 36;
        }
    }
}
