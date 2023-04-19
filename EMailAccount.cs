using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSystem
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
            this.Fullname = fullname;
            this.Login = login;
            this.Password = password;
            this.EMailAddress = $"{Login}.{DateTime.Now.ToString("yyyy")}@ms.com";
            EMailBox = new List<EMailBox>();
        }
    }
}
