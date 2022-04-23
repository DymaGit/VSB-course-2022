using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    interface Inter
    {
        void Connect(Train tr);
        void Disconnect(Train tr);

    }
    class Locomotive
    {
        Engine engine;
        Person driver;


        public Engine Engine
        {
            get { return engine; }
            set { engine = value; }
        }
        public Person Driver
        {
            get { return driver; }
            set { driver = value; }
        }


        public Locomotive()
        {

        }

        public Locomotive(Person driver, Engine engine)
        {
            this.driver = driver;
            this.engine = engine;
        }

        public override string ToString()
        {
            return GetType().Name + " Strojvedoucí: " + driver + engine;
        }
    }


    class Person
    {
        string firstName;
        string lastName;


        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }

        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }

        }

        public Person(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public override string ToString()
        {
            return FirstName + " " + lastName;
        }

    }
    class Engine
    {
        string type;



        public string Type
        {
            get { return (type); }
            set { type = value; }
        }

        public Engine(string type)
        {
            this.type = type;
        }

        public override string ToString()
        {
            return " typ motoru: " + type;
        }
    }



    class Chair
    {
        bool nearWindow;
        int number;
        bool reserved;


        public bool NearWindow
        {
            get { return nearWindow; }
            set { nearWindow = value; }
        }


        public int Number
        {
            get { return number; }
            set { number = value; }
        }

        public bool Reserved
        {
            get { return reserved; }
            set { reserved = value; }
        }

        public Chair(int number, bool nearWindow)
        {
            this.number = number + 1;
            this.nearWindow = nearWindow;
        }

    }

    class Bed
    {

        int number;
        bool reserved;

        public int Number
        {
            get { return number; }
            set { number = value; }

        }

        public bool Reserved
        {
            get { return reserved; }
            set { reserved = value; }
        }
        public Bed()
        {

        }
        public Bed(bool reserved)
        {
            Reserved = false;
        }

    }


    class Door
    {
        double height;
        double width;

        public double Height
        {
            get { return height; }
            set { height = value; }
        }
        public double Width
        {
            get { return width; }
            set { width = value; }
        }

        public Door(double height, double width)
        {
            this.height = height;
            this.width = width;
        }

    }

    abstract class PersonalWagon : Inter
    {
        List<Door> doors;
        int numberOfChairs;
        Chair[] sits;

        public List<Door> Doors
        {
            get { return doors; }
            set { doors = value; }
        }
        public Chair[] Sits
        {
            get { return sits; }
            set { sits = value; }
        }

        public PersonalWagon(int numberOfChairs)
        {
            this.numberOfChairs = numberOfChairs;
            Sits = new Chair[numberOfChairs];
            for (int i = 0; i < Sits.Length; i++)
            { //inicializace pole sedadel
                Sits[i] = new Chair(i, false);
                if (i > 0 && (i % 4 == 0 || i % 4 == 1))
                {
                    Sits[i].NearWindow = true;
                }
            }
            Doors = new List<Door>();
        }

       
        
        

        public int NumberOfChairs
        {
            get { return numberOfChairs; }
            set { numberOfChairs = value; }
        }

        public void Connect(Train tr)
        {

            //if (tr.Locomotive.Engine.Type == "steam" && tr.Vagony.Count >= 5)
            //{
            //    Console.WriteLine("Steam train can't have more than 5 wagons!");
            //}
            //else
            //{
            //    tr.Vagony.Add(this);

            //}
            if (tr.Locomotive.Engine.Type == "Parni")
            {
                if (tr.Vagony.Count < 5)
                {
                    tr.Vagony.Add(this);
                    Console.WriteLine(GetType().Name + " " + ToString());
                }
                else
                    Console.WriteLine("maximum je 5 vagónů");
            }
            else
            {
                tr.Vagony.Add(this);
                Console.WriteLine(GetType().Name + " " + ToString());
            }






        }
        public void Disconnect(Train vagon)
        {
            if (vagon.Vagony.Contains(this))
            {
                vagon.Vagony.Remove(this);
            }
            else
            {
                Console.WriteLine("This wagon is connected to a different train.");
            }
        }


    }

    class EconomyWagon : PersonalWagon
    {

        public EconomyWagon(int numberOfChairs) : base(numberOfChairs)
        {

        }

        public override string ToString()
        {
            return GetType().Name + " " + " počet sedadel: " + NumberOfChairs;
        }
    }


    class BusinessWagon : PersonalWagon
    {
        Person steward;

        public BusinessWagon(Person steward, int numberOfChairs) : base(numberOfChairs)
        {
            this.steward = steward;

        }

        public Person Steward
        {
            get { return steward; }
            set { steward = value; }
        }
        public override string ToString()
        {

            return GetType().Name + " Steward: " + steward;
        }
    }

    class NightWagon : PersonalWagon
    {
        int numberOfBeds;
        Bed[] beds = new Bed[5];


        public NightWagon(int numberOfBeds, int numberOfChairs) : base(numberOfChairs)
        {
            this.numberOfBeds = numberOfBeds;
        }

        public int NumberOfBeds
        {
            get { return numberOfBeds; }
            set { numberOfBeds = value; }
        }

        public Bed[] Beds
        {
            get { return beds; }
            set { beds = value; }
        }

        public override string ToString()
        {

            return GetType().Name + " počet sedadel: " + NumberOfChairs + ", počet lehátek: " + numberOfBeds;
        }
    }

    class Hopper : Inter
    {
        double loadingCapacity;

        public Hopper(double loadingCapacity)
        {
            this.loadingCapacity = loadingCapacity;
        }


        public double LoadingCapacity
        {
            get { return loadingCapacity; }
            set { loadingCapacity = value; }
        }


        public override string ToString()
        {

            return GetType().Name + " " + "kapacita vlaku: " + loadingCapacity;
        }

        public void Connect(Train tr)
        {

            tr.Vagony.Add(this);  //misto this může být vagon


        }
        public void Disconnect(Train tr)
        {
            tr.Vagony.Remove(this);
        }


    }
    class Train
    {

        Locomotive locomotive;
        List<Inter> vagony = new List<Inter>();

        public Train()
        {

        }
        public Locomotive Locomotive
        {
            get { return locomotive; }
            set { locomotive = value; }
        }

        public List<Inter> Vagony
        {
            get { return vagony; }
            set { vagony = value; }
        }



        public Train(Locomotive locomotive)
        {
            this.locomotive = locomotive;
        }

        public Train(Locomotive locomotive, List<Inter> vagony) : this(locomotive)
        {

            this.vagony = vagony;
        }



        public void ConnectWagon(Inter tr)
        {


            if (locomotive.Engine.Type == "Parni")
            {
                if (vagony.Count < 5)
                {
                    vagony.Add(tr);
                    Console.WriteLine(tr.GetType().Name + " " + tr.ToString());
                }
                else
                    Console.WriteLine("maximum je 5 vagónů");
            }
            else
            {
                vagony.Add(tr);
                Console.WriteLine(tr.GetType().Name + " " + tr.ToString());
            }
        }
        public void DisconnectWagon(Inter tr)
        {

            if (vagony.Count > 1)
            {
                vagony.Remove(tr);

                foreach (Inter item in vagony)
                {
                    Console.WriteLine(item);
                }
            }
            else
                Console.WriteLine("minimum je 1 vagón");
        }

        internal void ReserveChair(int wagonNumber, int seat)
        {
            if (this.Vagony[wagonNumber].GetType().BaseType.Name == "PersonalWagon")
            {
                if (((PersonalWagon)Vagony[wagonNumber]).Sits.Length < seat)
                {
                    Console.WriteLine($"No seat of this number in wagon {wagonNumber}!");
                }
                if (((PersonalWagon)Vagony[wagonNumber]).Sits[seat - 1].Reserved == true)
                { //-1, protoze podle je cislovane od 0 - pate sedadlo ma cislo 4
                    Console.WriteLine($"Seat {seat} in wagon {wagonNumber} is already reserved!");
                }
                else
                {
                    ((PersonalWagon)Vagony[wagonNumber]).Sits[seat - 1].Reserved = true;
                }

            }

        }
        internal void ListReservedChairs()
        {
            foreach (Inter vagonek in Vagony)
            {
                if (vagonek.GetType().BaseType.Name == "PersonalWagon")
                {
                    PersonalWagon car = (PersonalWagon)vagonek;
                    foreach (Chair chair in car.Sits)
                    {
                        if (chair.Reserved == true)
                        {
                            Console.WriteLine($"Wagon {Vagony.IndexOf(vagonek).ToString()}, seat {chair.Number}");
                        }
                    }
                }
            }
        }
    }


    class Testik
    {

        public static void Mainx()
        {
            Hopper h1 = new Hopper(100);
            Console.WriteLine(h1.ToString());

            NightWagon n1 = new NightWagon(50, 90);
            Console.WriteLine(n1.ToString());

            BusinessWagon b1 = new BusinessWagon(new Person("Lenka", "Kozáková"), 74);
            Console.WriteLine(b1.ToString());

            BusinessWagon b2 = new BusinessWagon(new Person("Fero", "Lakatoš"), 31);
            BusinessWagon b3 = new BusinessWagon(new Person("Pavel", "Sivák"), 52);
            EconomyWagon e1 = new EconomyWagon(99);
            EconomyWagon e2 = new EconomyWagon(55);
            EconomyWagon e3 = new EconomyWagon(105);


            Console.WriteLine(e1.ToString());

            Locomotive l1 = new Locomotive(new Person("Karel", "Novák"), new Engine("Parni"));
            Locomotive l2 = new Locomotive(new Person("Petr", "Koumal"), new Engine("Diesel"));
            Console.WriteLine(l1.ToString());

            Console.WriteLine();
            Console.WriteLine();
            Train t2 = new Train(l2);
            Train t1 = new Train(l1);
            Console.WriteLine(l1.ToString());//-----------

            t1.ConnectWagon(h1);
            t1.ConnectWagon(n1);
            t1.ConnectWagon(b1);
            t1.ConnectWagon(e1);

            Console.WriteLine();

            Console.WriteLine("Výpis po odpojení");
            Console.WriteLine(l1.ToString());
            t1.DisconnectWagon(n1);

            Console.WriteLine();
            Console.WriteLine("připojení dalších 4 vagónů");

            t1.ConnectWagon(b2);
            t1.ConnectWagon(b3);
            t1.ConnectWagon(e2);
            t1.ConnectWagon(e3);

            Console.WriteLine();

            EconomyWagon e4 = new EconomyWagon(28);
            EconomyWagon e5 = new EconomyWagon(33);
            EconomyWagon e6 = new EconomyWagon(49);
            EconomyWagon e7 = new EconomyWagon(55);
            EconomyWagon e8 = new EconomyWagon(100);
            t2.ConnectWagon(e4);
            t2.ConnectWagon(e5);
            t2.ConnectWagon(e6);
            t2.ConnectWagon(e7);
            t2.ConnectWagon(e8);

            EconomyWagon e9 = new EconomyWagon(200);
            EconomyWagon e10 = new EconomyWagon(250);
            e9.Connect(t2);
            e10.Connect(t1);
            Console.WriteLine(t2.Vagony.Count);
            Console.WriteLine(t1.Vagony.Count);


            t1.ReserveChair(2,15);
            t1.ListReservedChairs();

        }
    }

}



