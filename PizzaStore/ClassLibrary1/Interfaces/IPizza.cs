using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1.Interfaces
{
    //Define all pizza attributes
   public interface IPizza
    {

        string Crust { get; set; }
        string Sauce { get; set; }
        string Topping { get; set; }
        string Quantity { get; set; }


        decimal Price { get; set; }
        
    }
}
