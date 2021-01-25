using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;
using System.Threading.Channels;

namespace MyGame
{
    class CustomerManagerDal
    {
        private bool _kontrol = true;

        public List<Customer> customers = new List<Customer>() { };



        public void Add(Customer customer)
        {
            customers.Add(customer);
            Console.WriteLine();
            Console.WriteLine("---Müşteri sisteme eklendi!---");
            Console.WriteLine();

        }

        public void AddCustomer()
        {
            Console.Write("Kullanıcı adını giriniz: ");
            string name = Console.ReadLine();
            Console.Write("Kullanıcı soyadını giriniz: ");
            string lastName = Console.ReadLine();
            Console.Write("Kullanıcı TC.No giriniz: ");
            string tcNo = Console.ReadLine();



            Add(new Customer() { FirstName = name, LastName = lastName, TcNo = tcNo });

        }


        public void Update()
        {

            while (_kontrol == true)
            {

                Console.Write("Değişimesiniz istediğiniz müşterinin T.C Nosunu giriniz: ");
                string _secim = Console.ReadLine();

                foreach (var kCustomer in customers)
                {
                    if (_secim == kCustomer.TcNo)
                    {
                        Console.Write("Yeni adınızı giriniz: ");
                        string tempName = Console.ReadLine();
                        kCustomer.FirstName = tempName;
                        Console.Write("Yeni soyadınızı giriniz: ");
                        string tempLastName = Console.ReadLine();
                        kCustomer.LastName = tempLastName;
                        _kontrol = false;

                    }

                    else
                    {
                        Console.WriteLine("TcNo sistemde bulunamadı!");
                    }


                }



            }

        }

        public void Delete()
        {
            while (_kontrol == true)
            {
                Console.Write("Silinmesini istediğiniz kullanıcının TCNo'sunu giriniz: ");
                string tcNoInput = Console.ReadLine();

                foreach (var xCustomer in customers)
                {
                    if (xCustomer.TcNo == tcNoInput)
                    {
                        customers.Remove(xCustomer);

                        break;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Hatalı TcNo tekrar giriniz!");
                        Console.WriteLine();
                    }
                }
                _kontrol = false;

            }
        }

        public void ListCustomer()
        {
            foreach (var x in customers)
            {
                int sayac = 1;
                Console.WriteLine("{0}.Müşteri adı: {1}" + "\nSoyadı: {2}" + "\nT.C.No: {3}", sayac, x.FirstName, x.LastName, x.TcNo);
                Console.WriteLine("######## ");
                sayac += 1;
            }
        }
    }
}
