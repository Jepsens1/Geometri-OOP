using System;
using System.Collections.Generic;
using System.Text;

namespace Geometri_OOP
{
   public class Square : Shapes
    {
        

        public Square(double _side) : base(_side)
        {
            Side = _side;
        }
        public override double Omkreds()
        {
            return (4 * Side);
        }
        public override double Areal()
        {
            return (Side * Side);
        }

    }
}
