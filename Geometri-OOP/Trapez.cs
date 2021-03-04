using System;
using System.Collections.Generic;
using System.Text;

namespace Geometri_OOP
{
  public class Trapez : Shapes
    {
        private double sideC;

        public double SideC
        {
            get { return sideC; }
            set { sideC = value; }
        }
        private double sideD;

        public double SideD
        {
            get { return sideD; }
            set { sideD = value; }
        }
        public Trapez(double _sideA, double _sideB, double _sideC, double _sideD) : base(_sideA, _sideB)
        {
            SideC= _sideC;
            SideD = _sideD;
        }
        public double HeighCalculator()
        {
            //Making a variable that find out s
            double s = (Side + Sideb - sideC + sideD) / 2;
            //Returning the heigh
            return (2 / (Side - SideC)) + (Math.Sqrt(s * (s - Side + sideC) * (s - Sideb) * (s - sideD)));
        }
        public override double Areal()
        {
            return 0.5 * (Side + SideC) * HeighCalculator();
        }




    }
}
