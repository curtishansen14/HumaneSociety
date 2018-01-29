using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety.cs
{
    class Animal
    {
        private bool status;
        private int roomNumber;

        public Animal()
        {
            status = false;
        }

        public bool Status
        {
            get { return status; }
            set { status = value; }
        }

        public int RoomNumber
        {
            get { return roomNumber; }
            set { roomNumber = value; }
        }
    }
}
