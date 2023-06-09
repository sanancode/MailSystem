﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailSystem.Util;

namespace MailSystem.Management
{
    internal class EMailBoxManagement
    {
        public static void enterMailBox()
        {
            string emailaddress = MenuUtil.getString("\nPlease enter your email address: ");
            string password = MenuUtil.getString("Please enter your Password: ");

            //email address ve passwordu movcudlugunu teyin edir
            bool flag = false;
            for (int i = 0; i < Storage.mailAccounts.Count; i++)
            {
                if (Storage.mailAccounts[i].EMailAddress == emailaddress
                    && Storage.mailAccounts[i].Password == password)
                {
                    flag = true;
                    break;
                }
            }

            if (flag)
            {
                Console.WriteLine("\nYou've entered the account...\nEnjoy!");
                MailOperationsManagement.MailBoxOperationsMenuSelection(emailaddress);
                return;
            }
            else
            {
                Console.WriteLine("\nEmail or password address is wrong...Try again please...\n");
                enterMailBox();
                return;
            }
        }
    }
}
