namespace MailSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\tWelcome to Mail System\n");

            run();

            Console.WriteLine("\tEnded the system");
        }

        public static void run()
        {
            MenuUtil.Menu1();
            int menu = MenuUtil.selectMenuAbove();

            if (Common.checkMinAndMax(1, 3, menu))
            {
                switch (menu)
                {
                    case 1:
                        Console.WriteLine("\n\tRegistration\n");
                        RegistrationManagement.RegistrationProcess();
                        run();
                        break;
                    case 2:
                        EMailBoxManagement.enterMailBox();
                        run();
                        break;
                    case 3:
                        break;
                }
            }
            else
            {
                Common.throwErrRang(1, 3);
                run();
                return;
            }
        }
    }
}