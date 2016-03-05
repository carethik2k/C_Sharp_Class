using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBasics
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Staff objStaff = new Staff(100,"Karthik");
            
            Staff objStaff1 = new Staff();
            objStaff1.StaffID = 200;
            objStaff1.StaffName = "Manju";

            Staff objStaff2 = new Staff();
            objStaff2.StaffID = 300;
            objStaff2.StaffName = "Kuzhali";

            objStaff.PrintStaff();
            objStaff1.PrintStaff();
            objStaff2.PrintStaff();
        }
    }
}
