using System.Diagnostics;

namespace Exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {       
            Box first_box = new Box(width: 5.12, height:5.74, length:5.2);
            Box second_box = new Box(size: 10);
            Box third_box = new Box(oldBox: first_box);

            Box[] boxes = { first_box, second_box, third_box };

            calculateArea(boxes);
        }

        static void calculateArea(Box[] boxes)
        {
            foreach (Box box in boxes)
            {
                int index = Array.IndexOf(boxes, box) + 1;
                Console.WriteLine("Box {0}'s face area is: {1}", index, box.faceArea());
                Console.WriteLine("Box {0}'s side area is: {1}", index, box.sideArea());
                Console.WriteLine("Box {0}'s top area is: {1}", index, box.topArea());
                Console.WriteLine("Box {0}'s area is: {1}", index, box.area());
                Console.WriteLine("---------------------------------------------------");
            }
        }
    }
}