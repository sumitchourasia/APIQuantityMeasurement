﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Model.LengthModel
{
   public class Inch 
    {
        public double inch = 0.0;

        public Inch(double val)
        {
            this.inch = val;
        }

        public double Convert(Feet feetObject)
        {
            return this.inch / 12;
        }

        public double Convert(Inch inchObj)
        {
            return this.inch;
        }

        public double Convert(Yard yardObject)
        {
            return this.inch/36;
        }
    }
}
