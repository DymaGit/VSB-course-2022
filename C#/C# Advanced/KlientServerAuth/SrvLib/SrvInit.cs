using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SrvLib {
    public class SrvInit : MarshalByRefObject {
        public SrvAuth objekt = new SrvAuth();
        bool a = false;
        string name;
        string pass;
        public SrvAuth authorize(string name, string pass) {
            this.name = name;
            this.pass = pass;
            userAuthorization();
          if (a == true)
                return objekt;
          else
                return null;
        }

        private bool userAuthorization() {
            
            if (name == "Agent W4C" && pass == "abraka dabra")
                return a = true; 
            else
                return a = false;

        }



    }
}
