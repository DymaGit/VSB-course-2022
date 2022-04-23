using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DU
{



    class Deska
    {
        private string oznaceni;
        private string vyrobce;

        public Deska(string oznaceni, string vyrobce)
        {
            this.oznaceni = oznaceni;
            this.vyrobce = vyrobce;
        }
        //jak udšlat aby měly 2 konstruktory po jedné datové složce které jsou obě string?? nejspíš přetížením.
        public Deska()
        {

        }

        public string Oznaceni
        {
            get { return oznaceni; }
            set { oznaceni = value; }
        }

        public string Vyrobce
        {
            get { return vyrobce; }
            set { vyrobce = value; }
        }

        public string toString()
        {
            return Oznaceni + " " + Vyrobce;
        }

    }

    internal class Disk
    {
        private bool ssd;
        private int capacity;
        private string konektor;

        public Disk(bool ssd, int capacity, string konektor)
        {
            this.ssd = ssd;
            this.capacity = capacity;
            this.konektor = konektor;
        }

        public Disk()
        {

        }

        public bool SSD
        {
            get { return ssd; }
            set { ssd = value; }
        }

        public int Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }
        public string Konektor
        {
            get { return konektor; }
            set { konektor = value; }
        }

        public string toString()
        {
            return SSD + " " + Capacity + " " + Konektor;
        }

    }

    internal class Procesor
    {
        private string vyrobce2;
        private double frekvence;
        private string patice;

        public Procesor(string vyrobce2, double frekvence, string patice)
        {
            this.vyrobce2 = vyrobce2;
            this.frekvence = frekvence;
            this.patice = patice;
        }

        public Procesor()
        {

        }
        public string Vyrobce2
        {
            get { return vyrobce2; }
            set { vyrobce2 = value; }
        }

        public double Frekvence
        {
            get { return frekvence; }
            set { frekvence = value; }
        }

        public string Patice
        {
            get { return patice; }
            set { patice = value; }
        }

        public string toString()
        {
            return Vyrobce2 + " " + Frekvence + " " + Patice;

        }

    }

    internal class Ram
    {
        private string typ;
        private int kapacita;

        public Ram(string typ, int kapacita)
        {
            this.typ = typ;
            this.kapacita = kapacita;
        }
        public Ram()
        {

        }

        public string Typ
        {
            get { return typ; }
            set { typ = value; }
        }

        public int Kapacita
        {
            get { return kapacita; }
            set { kapacita = value; }
        }


        public string toString()
        {
            return Typ + " " + Kapacita;

        }
    }
     class Computer
    {
        private Procesor procak;
        private Disk hadr;
        private Ram operacka;
        private Deska deska;
    


        public Computer(Deska deska, Disk hadr, Ram operacka, Procesor procak)
        {
            this.deska = deska;
            this.hadr = hadr;
            this.operacka = operacka;
            this.procak = procak;
        }


        public Deska Deska
        {
            get { return deska; }
            set { deska = value; }
        }
        public Disk Hadr
        {
            get { return hadr; }
            set { hadr = value; }
        }
        public Ram Operacka
        {
            get { return operacka; }
            set { operacka = value; }
        }
        public Procesor Procak
        {
            get { return procak; }
            set { procak = value; }
        }



        public string toString()
        {
            return Deska.Oznaceni + Environment.NewLine+ Hadr.Konektor + Environment.NewLine + Operacka.Typ+ Environment.NewLine + Procak.Patice;

        }

    }

    class Ucebna
    {
        private Computer kolekcePC;
        private Computer kolekcePC2;

        public Ucebna(Computer kolekcePC, Computer kolekcePC2)
        {
            this.kolekcePC = kolekcePC;
            this.kolekcePC2=kolekcePC2;
        }

        public Computer KolekcePC
        {
            get { return kolekcePC; }
            set { kolekcePC= value; }
        }

        public Computer KolekcePC2
        {
            get { return kolekcePC2; }
            set { kolekcePC2 = value; }
        }
        public string toString()
        {
            return KolekcePC.toString() + Environment.NewLine+ KolekcePC2.toString()+ Environment.NewLine;

        }

    }



    class DU
    {
        public static void Mainx()
        {
            Deska deska = new Deska("1", "vyrobce Acer");
            Disk disk = new Disk(true, 100, "konektor abc");
            Procesor procesor = new Procesor("vyrobce HP", 50, "patice qq");
            Ram ram = new Ram("typ bcd", 1000);
            Computer cp = new Computer(deska,disk,ram,procesor);
            Console.WriteLine(deska.toString());
            Console.WriteLine(disk.toString());
            Console.WriteLine(procesor.toString());
            Console.WriteLine(ram.toString());
            
            Console.WriteLine(cp.toString());

          

            Computer cp2 = new Computer(new Deska("2","vyrobce Apple"), new Disk(false,200,"konektor ggj"), new Ram("typ 8",4000), new Procesor("vyrobce Alien", 100, "lol aa"));
            Console.WriteLine(cp2.toString());

            
            Console.WriteLine();


            Ucebna u1 = new Ucebna(cp, cp2);
          
            Console.WriteLine(u1.toString());

            Console.WriteLine(u1.KolekcePC2.Deska.Vyrobce);

        }

    }













}
