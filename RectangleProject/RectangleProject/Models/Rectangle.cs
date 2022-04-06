using System;
using System.Collections.Generic;
using System.Text;

namespace RectangleProject.Model
{
    class Rectangle
    {
        // mezőnevek
        private double sideA;
        private double sideB;

        // konstruktor példányosításakor használjuk
        public Rectangle(double sideA, double sideB)
        {
            this.sideA = sideA;
            this.sideB = sideB;
        }
    }
}
