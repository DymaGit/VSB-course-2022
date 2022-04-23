using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1_7
{
    internal class Date
    {
        private int day;
        private int month;
        private int year;

        public Date()
        {
            day = 1;
            month = 6;
            year = 2022;
        }

        public int getDay()
        {
            return day;
        }
        public int getMonth()
        {
            return month;
        }
        public int getYear()
        {
            return year;
        }

        public void setDay(int day)
        {
            this.day = day;
        }

        public void setMonth(int month)
        {
            this.month = month;
        }

        public void setYear(int year)
        {
            this.year = year;
        }

        public void setDate(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;   

        }

        public string toString()
        {
            return day+"/"+month+"/"+year;
        }
    }

    class ex1_7
    {
        public static void Mainx()
        {
            Date d1 =new Date();
            Console.WriteLine(d1.toString());
        }
    }


}
