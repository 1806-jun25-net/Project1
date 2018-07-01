using ClassLibrary1.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1.Models
{
    //store logs
    //pizzas sold
    //inventory
    //this is a portal for people who want to order pizza
    //also utilized by managers as well
    public class Location : ILocation
    {
        public int Order { get; set; }
        public int Address { get; set; }
        public int Inventory { get; set; }
    }
}
