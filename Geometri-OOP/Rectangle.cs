using System;
using System.Collections.Generic;
using System.Text;

namespace Geometri_OOP
{
    public class Rectangle : Shapes
    {
        public Rectangle(double _side, double _sideB) : base(_side, _sideB)
        {
            Sideb = _sideB;
        }
           
        public override double Omkreds()
        {
            return 2 * (Side + Sideb);
        }
        public override double Areal()
        {
            return (Side * Sideb);
        }
    }
}
