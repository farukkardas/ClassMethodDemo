using System;

namespace MyGameBackEnd
{
    class Program:MenuManager
    {
        static void Main(string[] args)
        {
            CustomerManagerDal customerManagerDal = new CustomerManagerDal();
            Customer customer = new Customer();
            MenuManager menu = new MenuManager();

            
            menu.PreMenu();

        }
    }
}
