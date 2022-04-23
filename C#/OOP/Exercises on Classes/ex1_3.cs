using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1_3
{
    class Rectangle
    {
        private float length;
        private float width;

        public Rectangle(float length, float width)
        {
            this.length = length;
            this.width = width;
        }

        public float getLenght()
        {
            return length;

        }

        public void setLenght(float lenght)
        {
            length = lenght;
        }


        public float getWidth()
        {
            return width;

        }

        public void setWidth(float width)
        {
            length = width;
        }

        public double getArea()
        {
            return (length * width);

        }

        public double getPerimeter()
        {
            return 2 * (length + width);
        }

        public string toString()
        {
            return length + " " + width;
        }
    }

    class ex1_3
    {
        public static void Mainx()
        {
            Rectangle r1 = new Rectangle(3, 4);
            Console.WriteLine(r1.getPerimeter());
            Rectangle r2 = new Rectangle(3, 4);
            Console.WriteLine(r2.toString());
        }
    }

}
