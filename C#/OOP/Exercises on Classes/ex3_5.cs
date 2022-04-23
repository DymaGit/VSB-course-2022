using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3_5

{
    class MyDate
    {
        private int year;
        private int month;
        private int day;
        private string[] strMonths = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
        private string[] strDays = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        private int[] daysInMonths = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        public bool isLeapYear(int year)
        {
            bool leap;

            if ((year % 100 == 0 && year % 400 == 0) || (year % 4 == 0 && year % 100 == 1))
                leap = true;
            else
                leap = false;

            return leap;
        }
        public bool isValidDate(int year, int month, int day)
        {
            bool valid;

            if ((year > 1 && year < 10000) && (month > 1 && month < 12) && (day > 1 && day < 31))
                valid = true;
            else
                valid = false;
            return valid;
        }
        public int getDayOfWeek(int year, int month, int day)
        {

            //komplikované, dodělám později
            //.. musim naprogramovat výpočet dne(po-ne) na základě číselného zadání data
            return 1;
        }
        public MyDate(int year, int month, int day)
        {
            Year = year;
            Month = month;
            Day = day;
        }

        public void setDate(int year, int month, int day)
        {
            this.year = year;
            this.month = month;
            this.day = day;

        }
        //public int getYear()
        //{
        //    return year;

        //}
 
        public int Year
        {
            get { return year; }
            set
            {
                if (value > 0 && value < 10000)
                {
                    year = value;
                }
                else
                {
                    //year = 0;  //předělat na zprávu


                    Console.WriteLine("chyba, špatný rok!");
                }
            }
        }
        public int Month
        {
            get { return month; }
            set
            {
                if (value > 0 && value < 13)
                    month = value;
                else
                    // month = 0;    //předělat na zprávu

                    Console.WriteLine("chyba, špatný měsíc!");
            }
        }
        public int Day
        {
            get { return day; }
            set
            {if (value > 0 && value < 32)
                    day = value;
                else
                  //  day = 0;  //předělat na zprávu
                Console.WriteLine("chyba, špatný den!");
            }

        }
        public string toString()
        {
            return "den: " + day + " měsíc: " + Month + " rok: " + Year;
        }

        public MyDate nextDay()
        {
            day++;
            return this;
        }

        public MyDate nextMonth()
        {
            month++;
            return this;
        }

        public MyDate nextYear()
        {
            year++;
            return this;
        }

        public MyDate previousDay()
        {
            day--;
            return this;
        }

        public MyDate previousMonth()
        {
            month--;
            return this;
        }
        public MyDate previousYear()
        {
            year--;
            return this;
        }
    }


    class ex3_5
    {
        public static void Mainx()
        {
            MyDate d1 = new MyDate(2015, 11,21);
            Console.WriteLine(d1.toString());

            d1.previousDay();
            d1.previousMonth();
            d1.previousYear();
            Console.WriteLine(d1.toString());
            Console.WriteLine(d1.isLeapYear(d1.Year));
            Console.WriteLine(d1.isValidDate(d1.Year, d1.Month, d1.Day));


        }
    }
}
