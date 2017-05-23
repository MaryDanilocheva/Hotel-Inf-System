using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Inf_System2
{
    public class User
    {
        public string firstName;
        public string lastName;
        public string otchName;
        public int room;
        public int reserv;
       
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string OtchName
        {
            get { return otchName; }
            set { otchName = value; }
        }
        public int Room
        {
            get { return room; }
            set { room = value; }
        }
        public int Reserv
        {
            get { return reserv; }
            set { reserv = value; }
        }
        public User(string _firstName, string _lastName, string _otchName, int _room, int _reserv)
        {
            firstName = _firstName;
            lastName = _lastName;
            otchName = _otchName;
            room = _room;
            reserv = _reserv;
        }
        private List<string> Listbox=new List<string>();

        public List<string> listbox
        {
            get { return Listbox; }
            set { Listbox = value; }
        }
        public User()
        {

        }


    }
    
    
    }

   

