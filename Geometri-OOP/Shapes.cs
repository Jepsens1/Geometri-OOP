using System;
using System.Collections.Generic;
using System.Text;

namespace Geometri_OOP
{
   public abstract class Shapes
    {
        private double side;

        public double Side
        {
            get { return side; }
            set { side = value; }
        }
        private double sideb;

        public double Sideb
        {
            get { return sideb; }
            set { sideb = value; }
        }
        //Creating constructors for each shape
        //Used in square
        public Shapes(double _side)
        {
            Side = _side;
        }
        public Shapes(double _side, double _sideB)
        {
            //Used in the rest
            Side = _side;
            Sideb = _sideB;
        }

        //Creating virtual methods that can i override to the specific shape
        public virtual double Omkreds()
        {
            return (4 * Side);
        }
        public virtual double Areal()
        {
            return (Side * Side);
        }


    }
}
