
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addressbook_UC4
{
    public class Contact
    {
        public string First_Name { get; set; }

        public string Last_Name { get; set; }
        public string Present_Address { get; set; }


        public string City { get; set; }

        public string State { get; set; }
        public string Email_Id { get; set; }
        public string Phone_Number { get; set; }
        public string Zip { get; set; }
    }
    public class ADDCONTACT
    {
        List<Contact> Addrlist = new List<Contact>();
        Contact contact = new Contact();
        public void AcceptDetails()
        {
            Console.WriteLine("Enter your first_name");
            contact.First_Name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter your last_name");
            contact.Last_Name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter your  Present_address");
            contact.Present_Address = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Enter your   City");
            contact.City = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Enter your State");
            contact.State = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter your Email_Id");
            contact.Email_Id = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter your Phone_Number");
            contact.Phone_Number = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Entered your ZipCode");

            Addrlist.Add(contact);
            Console.WriteLine("Contact Data Inserted SuccessFully");
        }

        public void DeleteContact()
        {
            Console.Write("Enter The first Name Of Contact You Have To Edit:");
            string First_usrname = Console.ReadLine();
            Console.Write("Enter The Last Name Of Contact You Have To Edit:");
            string Last_usrname = Console.ReadLine();
            foreach (var data in Addrlist)
            {
                if (data.First_Name == First_usrname && data.Last_Name == Last_usrname)
                {
                    data.First_Name = "";
                    data.Last_Name = "";
                    data.Present_Address ="";
                    data.City = "";
                    data.State = "";
                    data.Zip = "";
                    data.Phone_Number  = "";
                    data.Email_Id = "";
                }
                    Console.WriteLine("Contact deleted SuccessFully");
                }
            }
        
        public void DisplayDetails()
        {
            foreach (var data in Addrlist)
            {
                if (Addrlist.Contains(data))
                {
                    Console.WriteLine("FirstName: " + contact.First_Name + " LastName: " + contact.Last_Name
                             + " Address: " + contact.Present_Address + " City: " + contact.City + " State: "
                             + contact.State + " Zip: " + contact.Zip + " PhoneNumber: "
                             + contact.Phone_Number + " Email: " + contact.Email_Id);
                }
            }
        }
        public static void Main()
        {
            ADDCONTACT obj = new ADDCONTACT();
            obj.AcceptDetails();
            obj.DisplayDetails();
            obj.DeleteContact();
            obj.DisplayDetails();



        }
    }


}