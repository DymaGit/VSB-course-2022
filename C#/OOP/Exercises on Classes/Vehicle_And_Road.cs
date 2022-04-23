using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_And_Road
{
    class Vehicle
    {
        public int speed;
        public int typeOfRoad;


        public Vehicle(int speed, int typeOfRoad)
        {
            this.speed = speed;
            this.typeOfRoad = typeOfRoad;
        }


        public virtual void writeInfo()
        {
            int PovolenaRychlost = 0;
            string info = "";

            if (typeOfRoad == 1)
            {
                PovolenaRychlost = 50; info = " (Obec)";
                if (speed > 50)
                    info = "(Obec!) --> POKUTA!";
            }
            else if (typeOfRoad == 2)
            {
                PovolenaRychlost = 90; info = " (Mimo město)";
                if (speed > 90)
                    info = "(Mimo město!) --> POKUTA!";
            }
            else if (typeOfRoad == 3)
            {
                PovolenaRychlost = 130; info = " (Dálnice)";
                if (speed > 120)
                    info = "(Dálnice!) --> POKUTA!";
            }

            Console.WriteLine(PovolenaRychlost + " km/h " + info);
        }
    }

    class Car : Vehicle
    {
        public Car(int speed, int typeOfRoad) : base(speed, typeOfRoad)
        {
        }
    }


    class Motorcycle : Vehicle
    {
        public Motorcycle(int speed, int typeOfRoad) : base(speed, typeOfRoad)
        {
        }

    }

    class Tractor : Vehicle
    {
        public Tractor(int speed, int typeOfRoad) : base(speed, typeOfRoad)
        {
        }

        public override void writeInfo()
        {
            int PovolenaRychlost = 0;
            string info = "";

            if (typeOfRoad == 1)
            {
                PovolenaRychlost = 50; info = " (Obec)";
                if (speed > 50)
                    info = "(Obec!) --> POKUTA!";
            }
            else if (typeOfRoad == 2)
            {
                PovolenaRychlost = 50; info = " (Mimo město)";
                if (speed > 50)
                    info = "(Mimo město!) --> POKUTA!";
            }
            else if (typeOfRoad == 3)
            {
                PovolenaRychlost = 50;
                    info = "(Dálnice!.. Jsi traktor) --> POKUTA!";
            }

            Console.WriteLine(PovolenaRychlost + " km/h " + info);
        }

    }

    class Vehicle_And_Road
    {
        public static void Mainx()
        {
            Vehicle v1 = new Vehicle(200, 2);
            Car v2 = new Car(200, 3);
            Motorcycle v3 = new Motorcycle(100, 1); 
            Tractor v4 = new Tractor(45, 3);

            Console.Write("Rychlost: " + v1.speed + " ");
            v1.writeInfo();

            Console.Write("Rychlost: " + v2.speed + " ");
            v2.writeInfo();
            Console.Write("Rychlost: " + v3.speed + " ");
            v3.writeInfo();
            Console.Write("Rychlost: " + v4.speed + " ");
            v4.writeInfo();

        }

    }
}
