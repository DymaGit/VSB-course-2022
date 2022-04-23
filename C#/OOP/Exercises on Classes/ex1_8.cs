using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1_8

{
    class Time
    {
        private int hour;
        private int minute;
        private int second;

        public Time()
        {
            hour = 5;
            minute = 23;
            second = 33;
        }

        public int getHour()
        {
            return hour;
        }

        public int getMinute()
        {
            return minute;
        }
        public int getSecond()
        {
            return second;
        }

        public void setHour(int hour)
        {
            this.hour = hour;
        }

        public void setMinute(int minute)
        {
            this.minute = minute;
        }
        public void setSecond(int second)
        {
            this.second = second;
        }
        public void setTime(int hour, int minute, int second)
        {
            this.hour = hour;
            this.minute = minute;
            this.second = second;
        }

        public string toString()
        {
            return hour + ":" + minute + ":" + second;
        }

        public Time nextSecond()
        {
            second++;
            return this;
        }
        public Time previousSecond()
        {
            second--;
            return this;
        }
    }
    class ex1_8
    {
        public static void Mainx()
        {
            Time t1 = new Time();
            Console.WriteLine(t1.toString());
            t1.nextSecond();
            Console.WriteLine(t1.toString());
            t1.previousSecond();
            Console.WriteLine(t1.toString());
        }
    }
}
