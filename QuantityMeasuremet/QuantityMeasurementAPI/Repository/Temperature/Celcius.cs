using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Temperature
{
    public class Celcius
    {
        double celsius = 0.0;

        public Celcius(double celsius)
        {
            this.celsius = celsius;
        }

        public double Convert(Fahrenheit fahrenhietObject)
        {
            return (this.celsius * 9 / 5) + 32;
        }
    }
}
