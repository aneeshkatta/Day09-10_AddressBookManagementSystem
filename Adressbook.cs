
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day09AddressBook
{
    internal class Adressbook
    { 
       
           public static void Entry()
            {
                string First_Name;
                string Last_Name;
                string Present_Address;
                string Permanent_Address;
                string Village_OR_City;
                string Area;
                string District;
                string Mandal;
                string State;
                string Email_Id;
                int Phone_Number;
                Console.WriteLine("Enter your first_name");
                First_Name = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Enter your last_name");
                Last_Name = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Enter your  Present_address");
                Present_Address = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Enter your  Permanent_address");
                Permanent_Address = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Enter your  Village_OR_City");
                Village_OR_City = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Enter your   Area");
                Area = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Enter your   District");
                District = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Enter your Mandal");
                Mandal = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Enter your State");
                State = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Enter your Email_Id");
                Email_Id = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Enter your Phone_Number");
                Phone_Number = Convert.ToInt32(Console.ReadLine());


            }
        




    }
}
