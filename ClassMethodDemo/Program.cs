using System;



namespace ClassMethodDemo
{

    class Program
    {
        static void Main(string[] args)
        {
            // 3 adet müşteri oluşturdum.
            Customer customer1 = new Customer();
            Customer customer2 = new Customer();
            Customer customer3 = new Customer();

            //CustomerAccess classına gidip yeni bir üye oluşturdum ki metotlarını burada kullanabileyim.
            CustomerAccess customerAccess = new CustomerAccess();
            
            
            //Müşterilerin özelliklerini tayin etim.
            customerAccess.AddCustomer(customer1);
            customerAccess.AddCustomer(customer2);
            customerAccess.AddCustomer(customer3);

            // Bir liste oluşturup üyelerini bunun içine tayin ettim.
            Customer[] CustomerList = new Customer[] { customer1, customer2, customer3 };

            
            
            //CustomerAcess classımızın içerisindeki ListCustomer methodunu foreach ile yazdırdım.
            customerAccess.ListCustomer(customer1,customer2,customer3);
           
 

            // Burada müşteriden girdi aldım ona göre bir yol izlenecek.
            Console.WriteLine();
            Console.WriteLine("Yapmak istediğiniz işlemi seçiniz: ");
            Console.WriteLine("Enter. Müşteri Sil");
            Console.WriteLine("Esc. Çıkış Yap");
            Console.WriteLine();



            //Klavyeden basılan tuşa göre buradaki koşullar çalışacak.
            if (Console.ReadKey().Key == ConsoleKey.Enter)
            {
                int sayaco = 1;

                foreach (var listCustomer in CustomerList)
                {
                    Console.WriteLine();
                    Console.Write(sayaco + ". " + listCustomer.Name + " " + listCustomer.Surname);
                    Console.WriteLine();
                    sayaco++;

                }

                Console.WriteLine();
                Console.Write("Silmek istediğiniz müşterinin numarasını girip enter tuşuna basınız: ");
                int girdi = Convert.ToInt32(Console.ReadLine());

                if (girdi == 1)
                {
                    customerAccess.DeleteCustomer(customer1);
                    Environment.Exit(0);
                }

                if (girdi == 2)
                {
                    customerAccess.DeleteCustomer(customer2);
                    Environment.Exit(0);
                }
                if (girdi == 3)
                {
                    customerAccess.DeleteCustomer(customer3);
                    Environment.Exit(0);
                }

            }

            else if  (Console.ReadKey().Key == ConsoleKey.Escape)
            {
                Environment.Exit(0);
            }
        }
    }
}
