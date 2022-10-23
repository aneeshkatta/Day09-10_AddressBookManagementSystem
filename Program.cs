using Day09AddressBook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserCase02AddressBook
{
   internal class Program
    {
       public static void Main()
        {
            UC2 uC2 = new UC2();
            
            
            uC2.Entry();
            uC2.AddNewContact();
        }
           
    }
}
