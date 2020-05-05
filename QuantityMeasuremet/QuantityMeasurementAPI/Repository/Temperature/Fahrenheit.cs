using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Temperature
{
    public class Fahrenheit
    {
        double fahrenhiet = 0.0;

        public Fahrenheit(double fahrenhiet)
        {
            this.fahrenhiet = fahrenhiet;
        }

        public double Convert(Celcius celciusObject)
        {
            return (this.fahrenhiet - 32) * 5 / 9;
        }
    }
}
