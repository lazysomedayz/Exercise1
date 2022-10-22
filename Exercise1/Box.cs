using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    internal class Box
    {
        public double width { get; private set; }
        public double height { get; private set; }
        public double length { get; private set; }

        public Box(double width, double height, double length)
        {
            this.width = width;
            this.height = height;
            this.length = length;
        }

        public Box(double size)
        {
            width = size;
            height = size;
            length = size;
        }

        public Box(Box oldBox)
        {
            width = oldBox.width;
            height = oldBox.height;
            length = oldBox.length;
        }


        public double faceArea()
        {
            return width * height;
        }

        public double topArea()
        {
            return width * length;
        }

        public double sideArea()
        {
            return height * length;
        }

        public double area()
        {
            return 2 * faceArea() + 2 * topArea() + 2 * sideArea();
        } 
    }
}
