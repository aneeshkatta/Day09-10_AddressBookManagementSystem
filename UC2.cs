
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day09AddressBook
{
    internal class UC2
    {
        public string First_Name { get; set; }

        public string Last_Name { get; set; }
        public string Present_Address { get; set; }
        
       
        public string City { get; set; }
    
        public string State { get; set; }
        public string Email_Id { get; set; }
        public string Phone_Number { get; set; }
        public string Zip { get; set; }

        public  void Entry()
        {
         
            //public string Yes { get; set; }
            Console.WriteLine("Enter your first_name");
            First_Name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter your last_name");
            Last_Name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter your  Present_address");
            Present_Address = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Enter your   City");
            City = Convert.ToString(Console.ReadLine());
            
            Console.WriteLine("Enter your State");
            State = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter your Email_Id");
            Email_Id = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter your Phone_Number");
            Phone_Number = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Entered your ZipCode");
           
            Zip = Convert.ToString(Console.ReadLine());
     
            
                Console.WriteLine("FirstName: " + this.First_Name + " LastName: " + this.Last_Name
                                     + " Address: " + this.Present_Address + " City: " + this.City + " State: "
                                     + this.State + " Zip: " + this.Zip + " PhoneNumber: "
                                     + this.Phone_Number + " Email: " + this.Email_Id);
            
            
            //string[] AddressBookStore = { "First_Name", "Last_Name ", "Present_Address", "Permanent_Address_HouseNumber", " Village_OR_City", "Area", "District", " Mandal", "State", "Email_Id ", " Phone_Number" };
            //for (int i = 0; i < AddressBookStore.Length; i++)
            //{
            //    Console.WriteLine("" + AddressBookStore[i]);
            //}
            //Console.WriteLine("Do you want to Add a contact? then type Yes");
            //Yes = Convert.ToString(Console.ReadLine());

            //if (Yes != null)
            //{

            //    Entry();
            //}
            //else
            //{
            //    return;
            //}

        }
        public void AddNewContact()
        {
            Entry();
        }
        public void EditContact()
        {
            
        }
    }
}
       

