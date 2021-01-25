using System;
using System.Collections.Generic;
using System.Text;

namespace MyGame
{
    class MenuManager
    {
        public void MainMenu()
        {
            bool _kontrol = true;
           
            CustomerManagerDal customerManager = new CustomerManagerDal();
            MenuServices menuServices = new MenuServices();

            Console.WriteLine("---OYUN SATIŞ PLATFORMUNA HOŞGELDİNİZ---");
            Console.WriteLine();
            Console.WriteLine("1.Müşteri İşlemleri");
            

            while (_kontrol == true)
            {
                Console.WriteLine();
                Console.Write("Seçiminiz: ");
                int _secim = Int32.Parse(Console.ReadLine());

                if (_secim == 1)
                {
                    menuServices.CustomerServices();
                    _kontrol = false;
                    MainMenu();
                }


                else
                {
                    Console.WriteLine("Hatalı seçim!!");
                }


            }


        }
    }
}
