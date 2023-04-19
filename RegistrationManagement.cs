using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSystem
{
    internal class RegistrationManagement
    {
        public static void RegistrationProcess()
        {
            string fullname = MenuUtil.getString("Fullname: ");
            string login = MenuUtil.getString("Login: ");
            string password = MenuUtil.getString("Password: ");

            //eyni loginden varmi yoxlayir
            bool flag = true;
            for (int i = 0; i < Storage.mailAccounts.Count; i++)
            {
                if (Storage.mailAccounts[i].Login == login)
                {
                    flag = false;
                    break;
                }
            }

            if (!flag)
            {
                Console.WriteLine("\nLogin is already used...Please try another...\n");
                RegistrationProcess();
                return;
            }

            //registration completed
            EMailAccount newemailacc = new EMailAccount(fullname, login, password);
            Storage.mailAccounts.Add(newemailacc);

            Console.WriteLine("\nRegistration completed...");
            Console.WriteLine($"Email address automatically created: {newemailacc.EMailAddress}\n");
            return;
        }
    }
}
