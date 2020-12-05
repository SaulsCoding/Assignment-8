using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderingApp.Models
{
    public class TShirtOrders
    {
        [PrimaryKey, AutoIncrement]
        public int OrderId { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Date_of_Order { get; set; }
        public string T_Shirt_Color { get; set; }

        public string Shipping_Address { get; set; }

    }
}
