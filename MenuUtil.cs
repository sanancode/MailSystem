using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSystem
{
    internal class MenuUtil
    {
        public static void Menu1()
        {
            Console.WriteLine(
                "\n1. Create a mail account" +
                "\n2. Enter to account" +
                "\n3. Exit the system");
        }
        public static void Menu2()
        {
            Console.WriteLine(
                "\n1. Send an email" +
                "\n2. Show all unread mails" +
                "\n3. Previous menu");
        }

        public static int selectMenuAbove()
        {
            Console.Write("Please select the menu above: ");
            return int.Parse(Console.ReadLine());
        }

        public static int getInteger(string title)
        {
            Console.Write(title);
            return int.Parse(Console.ReadLine());
        }
        public static string getString(string title)
        {
            Console.Write(title);
            return Console.ReadLine();
        }
    }
}
