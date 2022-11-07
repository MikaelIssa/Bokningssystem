using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml;

namespace Labb3
{
    public class Booking
    {

        string Name ;
        string Time ;
        string Date;
        string TableNumber;

        public Booking(string name, string time, string date, string tablenumber)
        {
            Name = name;
            Time = time;
            Date = date;
            TableNumber = tablenumber;

        }

        public string name { get; set; }
        public string time { get; set; } 
        public string date { get; set; }
        public string tableNumber { get; set; }

        public override string ToString()
        {
            return $"{Name} {Time}/{Date} {TableNumber}";
        }
    }


}
