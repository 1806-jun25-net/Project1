using System;
using System.Collections.Generic;
using System.Text;
//define all user attributes
namespace ClassLibrary1.Interfaces
{
   public  interface IUser
    {

        string Name {get; set;}
        string Phone {get; set;}
        string Email {get; set;}
    }
}
