using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance2
{

    class Ship
    {
        public string name;
        public string year;

        public Ship(string name, string year)
        {
            this.name = name;
            this.year = year;
        }

        public virtual void toString()
        {
            Console.WriteLine(name + " " + year);

        }

    }

    class cruiseShip:Ship
    {
        public int maxpassangers;

        public cruiseShip(int maxpassangers, string name, string year) : base (name,year)
        {
            this.maxpassangers = maxpassangers;
            this.name=name;
        }
        public override void toString()
        {
            Console.WriteLine(name + " " + maxpassangers);

        }

      

    }


    class CargoShip : Ship
    {
        public int cargoCapacity;

        public CargoShip(int cargoCapacity,string name,string year): base (name,year)
        {
            this.cargoCapacity = cargoCapacity;
        }

        public override void toString()
        {
            Console.WriteLine(name + " " + cargoCapacity);

        }
    }

    class Inheritance2
    {
        public static void Mainx()
        {
            Ship s1 = new Ship("lola", "1555");
            s1.toString();
            cruiseShip s2 = new cruiseShip(133, "lod", "2003");
            s2.toString();
            CargoShip s3 = new CargoShip(500,"lodka","2020");
            s3.toString();
            Console.WriteLine();

            Ship[] aaa = new Ship[] { s1, s2 , s3 };
            
            for (int i = 0; i < aaa.Length; i++)
            aaa[i].toString();

        }
    }
}
