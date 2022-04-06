using System;
using System.Collections.Generic;
using System.Text;

namespace RectangleProject.Models
{
    public class Rectangle
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

        // tulajdonság (property)
        public double SideA
        {
            get
            {
                return sideA;
            }

            set
            {
                sideA = value;
            }
        }

        public double SideB
        {
            get
            {
                return sideB;
            }

            set
            {
                sideB = value;
            }
        }

        public double Area
        {
            get
            {
                double area = sideA * sideB;
                return area;
            }
        }

        public double Perimeter
        {
            get
            {
                double perimeter = 2 * (sideA + sideB);
                return perimeter;
            }
        }

        public override string ToString()
        {
            double sideARound = Math.Round(sideA, 2);
            double sideBRound = Math.Round(sideB, 2);
            double areaRound = Math.Round(Area, 2);
            double perimeterRound = Math.Round(Perimeter, 2);
            string result = "A oldal: " + sideA + "\n";
            result += "B oldal: " + sideB + "\n";
            result += "Terület: " + area + "\n";
            result += "Kerület: " + perimeter + "\n";
            return result;
        }
    }
}
