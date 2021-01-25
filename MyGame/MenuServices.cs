using System;
using System.Collections.Generic;
using System.Text;

namespace MyGame
{
    public class MenuServices
    {
        private CustomerManagerDal customerManager = new CustomerManagerDal();
        private Customer customer = new Customer();

        private bool _kontrol = true;
        public void CustomerServices()
        {
            Console.WriteLine("1.Müşteri Listele");
            Console.WriteLine("2.Müşteri Ekle");
            Console.WriteLine("3.Müşteri Güncelle");
            Console.WriteLine("4.Müşteri Sil");

            while (_kontrol == true)
            {
                int _secim = Int32.Parse(Console.ReadLine());

                if (_secim == 1)
                {
                    customerManager.ListCustomer();
                    _kontrol = false;
                }

                else if (_secim == 2)
                {
                    customerManager.Add();
                    _kontrol = false;
                }

                else if (_secim == 3)
                {
                    customerManager.Update();
                    _kontrol = false;
                }

                else if (_secim == 4)
                {
                    customerManager.Delete();
                    _kontrol = false;
                }

                else
                {
                    Console.WriteLine("Hatalı seçim!");
                }

                
            }
        }

    }
}
