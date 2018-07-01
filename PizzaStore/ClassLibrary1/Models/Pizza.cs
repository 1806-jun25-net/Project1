using ClassLibrary1.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1.Models
{

    //pizza architechture
    public class Pizza : IPizza
    {
        public string Crust { get; set; }
        public string Sauce { get; set; }
        public string Topping { get; set; }
        public decimal Price { get; set; }
        public string Quantity { get; set; }
        }
}
