using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBasics
{
    class Staff
    {
        public int intField = 10;

        public Staff()
        { }

        public Staff(int id, string name)
        {
            StaffID = id;
            StaffName = name;
        }

        public int StaffID { get; set; } = 20;
        public string StaffName { get; set; } = "John";
        public string StaffAddress { get; set; } = "15356 Pratt Plz, Apt 175 Omaha NE 68116";

        public void PrintStaff()
        {
            Console.WriteLine(StaffID);
            Console.WriteLine(StaffName);
            Console.WriteLine(StaffAddress);
        }
    }
}
