using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSystem.Classes
{
    internal class EMailAccount
    {
        public string Fullname { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string EMailAddress { get; set; }
        public List<EMailBox> EMailBox { get; set; }
        public EMailAccount(string fullname, string login, string password)
        {
            Fullname = fullname;
            Login = login;
            Password = password;
            EMailAddress = $"{Login}.{DateTime.Now.ToString("yyyy")}@ms.com";
            EMailBox = new List<EMailBox>();
        }
    }
}
