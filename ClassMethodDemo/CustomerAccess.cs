using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class CustomerAccess
    {
        public void AddCustomer(Customer customer)
        {
            
            Console.Write("Müşterinin Adı: ");
            customer.Name = Console.ReadLine();
            Console.Write("Müşterinin Soyadı: ");
            customer.Surname = Console.ReadLine();
            Console.Write("Müşterinin Bakiyesi: ");
            customer.Balance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("--- Müşteri başarı ile oluşturuldu ---");
            Console.WriteLine();      
            
        }

        public void DeleteCustomer(Customer customer)
        {
            Console.WriteLine();
            Console.WriteLine(customer.Name + " " + customer.Surname + " adlı müşteri sistemden silinmiştir.");
        }

        public void ListCustomer(Customer customer1, Customer customer2, Customer customer3)
        {
            Customer[] ListCustomer = new Customer[] { customer1, customer2, customer3 };

            int listSayac = 1;
            foreach (var item in ListCustomer )
            {
                Console.Write(listSayac + ". müşterinin ismi: "); ;
                Console.WriteLine(item.Name);
                Console.Write(listSayac + ". müşterinin soyismi: ");
                Console.WriteLine(item.Surname);
                Console.Write(listSayac + ". müşterinin bakiyesi: ");
                Console.WriteLine(item.Balance);
                Console.WriteLine();
                Console.WriteLine("-------");
                Console.WriteLine();
                
                listSayac++;
            }

            
        }

    }
}
