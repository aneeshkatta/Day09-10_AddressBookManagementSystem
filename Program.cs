using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserCase02AddressBook
{
    internal class Program
    {
        
        class Create_Contact
        {
            class Contact
            {
                public string FirstName { get; set; }
                public string LastName { get; set; }
                public string Address { get; set; }
                public string State { get; set; }
                public string PhoneNumber { get; set; }
                public string Email { get; set; }
                public string ZipCode { get; set; }
            }
            List<Contact>AddressbookList = new List<Contact>();
            public void AddContactDetails()   
            {
                Contact contact = new Contact();
                Console.WriteLine("Enter the First Name");

                contact.FirstName = Console.ReadLine();
                Console.WriteLine("Enter the Last Name");
                contact.LastName = Console.ReadLine();
                Console.WriteLine("Enter the Adresss");
                contact.Address = Console.ReadLine();
                Console.WriteLine("Enter the State");
                contact.State = Console.ReadLine();
                Console.WriteLine("Enter the Zip Code");
                contact.ZipCode = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Enter the Phone Number");
                contact.PhoneNumber = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Enter the Email");
                contact.Email = Console.ReadLine();
                AddressbookList.Add(contact);
                Console.ReadKey();
            }
            public void Display()     
            {
                foreach (var data in AddressbookList)
                {
                    if (AddressbookList.Contains(data))
                        Console.WriteLine("*************Contact Details****************");
                    Console.WriteLine($"Name of person : {data.FirstName} {data.LastName}");
                    Console.WriteLine($"Address of person is : {data.Address}");
                    Console.WriteLine($"State : {data.State}");
                    Console.WriteLine($"Zip : {data.ZipCode}");
                    Console.WriteLine($"Email of person : {data.Email}");
                    Console.WriteLine($"Phone Number of person : {data.PhoneNumber}");
                }
                Console.WriteLine();
            }
            public void edit()
            {
                Console.WriteLine("Enter the name of contact do you want to edit : ");
                string name = Convert.ToString(Console.ReadLine());
                foreach (var data in AddressbookList)
                {
                    if (data.FirstName == name)
                    {
                        Console.WriteLine("choose the option to change the data : \n1) firstName\n2)lastName\n3)address\n4)City\n5)State\n6)Zip\n7)Email\n8)Phone Number");
                        int choice = Convert.ToInt32(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:
                                Console.WriteLine("Please enter the first name : ");
                                string firstName = Convert.ToString(Console.ReadLine());
                                data.FirstName = firstName;
                                break;
                            case 2:
                                Console.WriteLine("Please enter the last name : ");
                                string lastName = Convert.ToString(Console.ReadLine());
                                data.LastName = lastName;
                                break;
                            case 3:
                                Console.WriteLine("Please enter the Address : ");
                                string address = Convert.ToString(Console.ReadLine());
                                data.Address = address;
                                break;
                            case 4:
                                Console.WriteLine("Please enter the city : ");
                                string State = Convert.ToString(Console.ReadLine());
                                data.State = State;
                                break;
                            case 6:
                                Console.WriteLine("Please enter the zip Code : ");
                                string ZipCode = Convert.ToString(Console.ReadLine());
                                data.ZipCode = ZipCode;
                                break;
                            case 7:
                                Console.WriteLine("Please enter the email : ");
                                string Email = Convert.ToString(Console.ReadLine());
                                data.Email = Email;
                                break;
                            case 8:
                                Console.WriteLine("Please enter the Phone Number : ");
                                string PhoneNumber = Convert.ToString(Console.ReadLine());
                                data.PhoneNumber = PhoneNumber;
                                break;
                            default:
                                Console.WriteLine("please choose from above options :");
                                break;
                        }
                        Console.WriteLine();
                        Display();
                    }
                    else
                    {
                        Console.WriteLine($"Contact not found{name}");
                    }

                }

            }
            public static void Main(String[] args)
            {
                Create_Contact AddressBook = new Create_Contact();
                AddressBook.AddContactDetails();
                AddressBook.Display();
                AddressBook.edit();
                Console.ReadKey();
            }
        }

    }
}
