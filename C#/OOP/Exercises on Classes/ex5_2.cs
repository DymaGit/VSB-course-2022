using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex5_2
{

    class Circle
    {
        private double radius;
        private string color;

        public Circle()
        {
            radius = 1.0;
            color = "red";
        }
    }

    class cylinder
    {
        private Circle odkaz;
        private double height;

        public cylinder()
        {
            odkaz = new Circle();
            height = 1.0;

        }

    }
     class ex5_2
    {

        public static void Mainx()
        {
           
        }

    }
}
