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

        string name;
        string time;
        string date;
        string tableNumber;

        public Booking(string name, string time, string date, string tableNumber)
        {
            Name = name;
            Time = time;
            Date = date;
            TableNumber = tableNumber;

        }

        public string Name { get; set; }
        public string Time { get; set; } 
        public string Date { get; set; }
        public string TableNumber { get; set; }

        public override string ToString()
        {
            return $"{Name} {Time}/{Date}  table {TableNumber}";
        }
    }


}
