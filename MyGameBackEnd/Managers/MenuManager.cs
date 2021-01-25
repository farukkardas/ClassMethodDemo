using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;
using MyGameBackEnd.Managers;

namespace MyGameBackEnd
{
    public class MenuManager
    {
        private List<Customer> customers = new List<Customer>() { };
        private List<Campaign> campaigns = new List<Campaign>() { };
        private Campaign campaign = new Campaign();
        private CustomerManagerDal customerManagerDal = new CustomerManagerDal();
        private CampaignManager campaignManager = new CampaignManager();
        
        


        public void PreMenu()
        {
            Console.WriteLine("Oyun menüsüne hoşgeldiniz.");
            Console.WriteLine();
            LoginMenu();

        }

   
        public void LoginMenu()
        {
            Console.WriteLine("1. Kayıt Ol");
            Console.WriteLine("2. Çıkış");
            
            bool _kontrol = true;

            while (_kontrol == true) {
                Console.WriteLine();
                Console.Write("İşleminiz: ");
                string _choice = Console.ReadLine();

                if (_choice == "1")
                {
                    customerManagerDal.Add(customer);
                    _kontrol = false;
                    MainMenu();
                }

                else if (_choice == "2")
                {
                    Console.WriteLine("Uygulamadan çıkıldı.");
                    Environment.Exit(0);
                    
                }

                else
                {
                    Console.WriteLine("Hatalı seçim!");
                    _kontrol = true;
                }

            }


        }

        public void MainMenu()
        {
            Console.WriteLine();
            Console.WriteLine("1.Hesap işlemleri");
            Console.WriteLine("2.Kampanyaları Listele ");
            Console.WriteLine("3.Kampanya işlemleri");
            Console.WriteLine("4.Çıkış");
            
            bool _kontrol = true;
            while (_kontrol == true)
            {
                Console.WriteLine();
                Console.Write("İşleminiz: ");
                string _choice = Console.ReadLine();

                if (_choice == "1")
                {
                    CustomerProcesses();
                    _kontrol = false;
                    MainMenu();

                }

                else if (_choice == "2")
                {
                    Console.WriteLine();
                    campaignManager.ListCampaign();
                    _kontrol = false;
                    MainMenu();
                }


                else if (_choice == "3")
                {
                  CampaignProcess();
                    _kontrol = false;
                    MainMenu();
                }

            }

        }

        public void CustomerProcesses()
        {
            Console.WriteLine("1. Kullanıcıları listele");
            Console.WriteLine("2. Hesabı güncelle");
            Console.WriteLine("3. Hesabı sil");
           
            bool _kontrol = true;
            while (_kontrol == true)
            {
                Console.WriteLine();
                Console.Write("İşleminiz: ");
                string _choice = Console.ReadLine();

                if (_choice == "1")
                {
                    customerManagerDal.ListPlayer();
                    _kontrol = false;
                    MainMenu();
                }
                
                
                else if (_choice == "2")
                {
                    customerManagerDal.Update(customer);
                    _kontrol = false;
                    MainMenu();

                }

                else if (_choice == "3")
                {
                    customerManagerDal.Delete(customer);
                    _kontrol = false;
                    MainMenu();
                }

                else
                {
                    Console.WriteLine("Hatalı seçim!");
                    _kontrol = true;
                }

            }


        }

        public void CampaignProcess()
        {
            Console.WriteLine();
            Console.WriteLine("1. Kampanya Ekle");
            Console.WriteLine("2. Kampanya Güncelle");
            Console.WriteLine("3. Kampanya Sil");
           
            bool _kontrol = true;
            while (_kontrol == true)
            {
                Console.WriteLine();
                Console.Write("İşleminiz: ");
                string _choice = Console.ReadLine();

                if (_choice == "1")
                {
                    campaigns.Add(campaign);
                    _kontrol = false;
                    MainMenu();

                }

                else if (_choice == "2")
                {
                    campaignManager.Update(campaign);
                    _kontrol = false;
                    MainMenu();
                }

                else if (_choice == "3")
                {
                    campaignManager.Delete(campaign);
                    _kontrol = false;
                    MainMenu();
                    
                }
                else
                {
                    Console.WriteLine("Hatalı seçim!");
                    _kontrol = true;
                }

            }
        }




    }
}




