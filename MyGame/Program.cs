using System;

namespace MyGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //MenuManager menuManager = new MenuManager();
            CustomerManagerDal customerManager = new CustomerManagerDal();

            customerManager.AddCustomer();
            customerManager.ListCustomer();
            //menuManager.MainMenu();
        }
    }
}
