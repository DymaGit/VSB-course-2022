using SrvInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SrvLib {
    public class SrvInit : MarshalByRefObject, ISrvInit {
        public SrvAuth objekt = new SrvAuth();
        bool a = false;
        string name;
        string pass;
        public ISrvAuth authorize(string name, string pass) {
            this.name = name;
            this.pass = pass;
            userAuthorization();
          if (a == true)
                //return obj;  //řekl bych že je to samé  
                return new SrvAuth();
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
