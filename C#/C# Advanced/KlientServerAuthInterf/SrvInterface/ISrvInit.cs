using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SrvInterface
{
    public interface ISrvInit {
        ISrvAuth authorize(string name, string pass);
    }


}
