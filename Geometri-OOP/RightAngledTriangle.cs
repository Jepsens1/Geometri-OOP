using System;
using System.Collections.Generic;
using System.Text;

namespace Geometri_OOP
{
    class RightAngledTriangle : Shapes
    {
        private double sideC;

        public double SideC
        {
            get { return sideC; }
            set { sideC = value; }
        }
        public RightAngledTriangle(double _side, double _sideB) : base(_side, _sideB)
        {
            SideC = Math.Sqrt(Math.Pow(_side, 2) + Math.Pow(_sideB, 2));

        }
        public override double Omkreds()
        {
            return Side + Sideb + sideC;
        }
        public override double Areal()
        {
            return 0.5 * (Side + Sideb);
        }

    }
}
