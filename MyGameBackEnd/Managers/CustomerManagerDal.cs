using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;


namespace MyGameBackEnd
{
    public class CustomerManagerDal : ILogger
    {
        private List<Customer> customers = new List<Customer>() { };
        public void Add(Customer customer)
        {
            customers.Add(customer);
            Console.Write("Kullanıcı adınızı giriniz: ");
            customer.CustomerNickname = Console.ReadLine();
            Console.Write("Adınızı Giriniz: ");
            customer.FirstName = Console.ReadLine();
            Console.Write("Soyadınızı Giriniz: ");
            customer.LastName = Console.ReadLine();
            Console.Write("Doğum yılınızı giriniz: ");
            customer.BirthYear = Int32.Parse(Console.ReadLine());
            Console.Write("Tc kimlik no giriniz: ");
            customer.TcNo = Console.ReadLine();

        }

        public void Delete(Customer customer)
        {
            bool _kontrol = true;
            Console.WriteLine();
           
            while (_kontrol == true)
            {
                Console.Write("Silmek istediğiniz hesabın TC No'sunu yazınız: ");
                string _choice = Console.ReadLine();
                if (_choice == customer.TcNo)
                {
                    customers.Remove(customer);
                    _kontrol = false;
                }

                else
                {
                    Console.WriteLine("Yanlış değer girdiniz.");
                }
            }


            Console.WriteLine("Hesap Silinmiştir!!");

            customers.Remove(customer);

        }

        public void Update(Customer customer)
        {
            Console.WriteLine("Değiştirmek istediğiniz özelliğinizi seçiniz.");
            Console.WriteLine("1. Kullanıcı adı");
            Console.WriteLine("2. Adı");
            Console.WriteLine("3. Soyadı");

            bool _donguKontrol = true;

            while (_donguKontrol == true)
            {
                Console.WriteLine();
                Console.Write("İşleminiz: ");
                int choice = Int32.Parse(Console.ReadLine());


                if (choice == 1)
                {
                    Console.WriteLine("ID: {0}", customer.CustomerNickname);
                    Console.Write("Yeni kullanıcı adınızı giriniz: ");
                    customer.CustomerNickname = Console.ReadLine();
                    Console.WriteLine("New ID: {0}", customer.CustomerNickname);
                    _donguKontrol = false;

                }

                else if (choice == 2)
                {
                    Console.WriteLine("Adınız: {0}", customer.FirstName);
                    Console.Write("Güncellenecek adınızı giriniz: ");
                    customer.FirstName = Console.ReadLine();
                    Console.WriteLine("Yeni adınız: {0}", customer.FirstName);
                    _donguKontrol = false;

                }

                else if (choice == 3)

                {
                    Console.WriteLine("Soyadınız: {0}", customer.LastName);
                    Console.Write("Güncellenecek soyadınızı giriniz: ");
                    customer.LastName = Console.ReadLine();
                    _donguKontrol = false;
                    Console.WriteLine("ID: {0}", customer.LastName);

                }

                else
                {
                    Console.WriteLine("Hatalı giriş.");
                }
            }

        }

        public void ListPlayer()
        {
            if (customers.Count == 0)
            {
                Console.WriteLine();
                Console.WriteLine("Kullanıcı bulunamadı.");
            }
            else
            {
                int sayac = 1;
                foreach (var cxtmCustomer in customers)
                {
                    {
                        Console.WriteLine();
                        Console.WriteLine(
                            "{0}. Kullanıcı Nickname:  {1} " + "\nAdı: {2}" + "\nSoyadı: {3}" + "\nTc NO: {4}", sayac,
                            cxtmCustomer.CustomerNickname, cxtmCustomer.FirstName, cxtmCustomer.LastName,
                            cxtmCustomer.TcNo);
                        sayac += 1;
                    }
                }
            }
        }

        public void AddInfo()
        {
            Console.WriteLine("Müşteri başarılı bir şekilde silindi");
        }

        public void UpdateInfo()
        {
            Console.WriteLine("Müşteri başarılı bir şekilde güncellendi.");
        }

        public void DeleteInfo()
        {
            Console.WriteLine("Müşteri başarılı bir şekilde silindi");
        }
    }
}
