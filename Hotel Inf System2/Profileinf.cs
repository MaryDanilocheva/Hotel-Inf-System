using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Inf_System2
{
    public class Profileinf
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string inf;

        public string Inf
        {
            get { return inf; }
            set { inf = value; }
        }
        public Profileinf(string _name, string _inf)
        {
            name = _name;
            inf = _inf;
        }
       public Profileinf()
        {

       }
    }
}
