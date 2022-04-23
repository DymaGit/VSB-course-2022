using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreatFormTime.implementation {
    public class Clock {
        private bool shows = true;


        public void show() {
            shows = true;
            Console.WriteLine("--- on");

        }

        public void doNotShow() {
            shows = false;
            Console.WriteLine("--- off");

        }

        public void loop() {


            while (true) {
                if (shows == true) {
                    Console.WriteLine(DateTime.Now.ToLongTimeString());
                    Thread.Sleep(1000);
                }
            }

        }


    }
}
