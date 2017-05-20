using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Hotel_Inf_System2
{
    public class Human
    {
        public const int DefaultRating = 5;

        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        // 100-599
        private int _room;

        public int Room
        {
            get { return _room; }
            set { _room = value; }
        }

        public string Info
        {
            get
            {
                return $"{_name} - {_room}";
            }
        }
    }
}
