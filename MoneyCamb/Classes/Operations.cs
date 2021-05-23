using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyCamb.Classes
{
    public class Operations
    {
        public int Operation_Id { get; set; }
        public string Client { get; set; }
        public string Origin_Coin { get; set; }
        public string Dest_Coin { get; set; }
        public double Origin_Value { get; set; }
        public double Dest_Value { get; set; }
        public DateTime Operation_Date { get; set; }
        public double rate { get; set; }
    }
}
