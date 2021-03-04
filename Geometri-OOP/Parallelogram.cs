using System;
using System.Collections.Generic;
using System.Text;

namespace Geometri_OOP
{
    class Parallelogram : Shapes
    {
        private double slope;

        public double Slope
        {
            get { return slope; }
            set { slope = value; }
        }
        public Parallelogram(double _side, double _sideb, double _slope) : base(_side, _sideb)
        {
            Slope = _slope;
        }

        public override double Areal()
        {
            return Side * Sideb * Math.Sin(Slope);
        }
        


    }
}
