using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailSystem.Classes;
using MailSystem.Util;

namespace MailSystem.Management
{
    internal class MailOperationsManagement
    {
        public static void MailBoxOperationsMenuSelection(string emailaddress)
        {
            //emailaddress - arqument mailin kim terefinden gonderildiyini teyin etmek ucundur (cari olaraq aciq olan accaunt)

            MenuUtil.Menu2();
            int menu = MenuUtil.selectMenuAbove();

            switch (menu)
            {
                case 1:
                    Console.WriteLine("\nSend email...");
                    sendEMail(emailaddress);
                    MailBoxOperationsMenuSelection(emailaddress);
                    break;
                case 2:
                    showUnreadEMails(emailaddress);
                    MailBoxOperationsMenuSelection(emailaddress);
                    break;
                case 3:
                    break;
            }
        }

        public static void sendEMail(string emailaddress)
        {
            string to = MenuUtil.getString("To: ");

            if (checkto())
            {
                string subject = MenuUtil.getString("Subject: ");
                string text = MenuUtil.getString("Text: ");
                string from = Storage.mailAccounts[fromwho()].Fullname + " - " + Storage.mailAccounts[fromwho()].EMailAddress;

                EMailBox newemail = new EMailBox(subject, text, from);
                Storage.mailAccounts[towho()].EMailBox.Add(newemail);
                Console.WriteLine($"\nEmail sent to {Storage.mailAccounts[towho()].Fullname}...");
            }
            else
            {
                Console.WriteLine("\nEmail address not found...Try again please...\n");
                sendEMail(emailaddress);
                return;
            }

            #region Inner Methods
            bool checkto()
            {
                for (int i = 0; i < Storage.mailAccounts.Count; i++)
                {
                    if (to == Storage.mailAccounts[i].EMailAddress)
                    {
                        return true;
                    }
                }
                return false;
            }

            int fromwho()
            {
                //mailin kim terefinden gonderildiyini teyin edir
                //Listdeki index nomresini teyin edir

                for (int i = 0; i < Storage.mailAccounts.Count; i++)
                {
                    if (Storage.mailAccounts[i].EMailAddress == emailaddress)
                    {
                        return i;
                    }
                }
                return 0;
            }

            int towho()
            {
                //mailin kime gonderildiyini teyin edir
                //Listdeki index nomresini teyin edir

                for (int i = 0; i < Storage.mailAccounts.Count; i++)
                {
                    if (Storage.mailAccounts[i].EMailAddress == to)
                    {
                        return i;
                    }
                }
                return 0;
            }
            #endregion
        }

        public static void showUnreadEMails(string emailaddress)
        {
            Console.WriteLine("\n");
            int row = 1;
            int activeaccindex = 0;
            bool flag = false; //true olarsa unread mail var demekdir

            //unread olan mailleri gosterir
            for (int i = 0; i < Storage.mailAccounts.Count; i++) //email accountlar uzre addimlama
            {
                if (emailaddress == Storage.mailAccounts[i].EMailAddress) //cari olaraq aktiv olan acc-lar arasinda tapir
                {
                    activeaccindex = i;
                    for (int j = 0; j < Storage.mailAccounts[i].EMailBox.Count; j++) //cari acc-u tapdiqdan sonra acc-da olan emaillar uzerinde addimlama
                    {
                        if (Storage.mailAccounts[i].EMailBox[j].Status == true) //emaillardan statusu active(true) olanlari capa teyin edir (sonra capa verir)
                        {
                            Console.WriteLine($"{row}. mail: {Storage.mailAccounts[i].EMailBox[j].Subject} , to open press: {j}");
                            row++;
                            flag = true;
                        }
                    }
                }
            }

            //sec ve mailin icini goster
            if (flag)
            {
                int mailnum = MenuUtil.selectMenuAbove();

                Console.WriteLine($"\nFrom: {Storage.mailAccounts[activeaccindex].EMailBox[mailnum].From}");
                Console.WriteLine($"Subject: {Storage.mailAccounts[activeaccindex].EMailBox[mailnum].Subject}");
                Console.WriteLine($"Mail: {Storage.mailAccounts[activeaccindex].EMailBox[mailnum].Text}");
                Storage.mailAccounts[activeaccindex].EMailBox[mailnum].Status = false;
            }
            else
            {
                Console.WriteLine("\nThere is not any unread emails\n");
            }
        }
    }
}
