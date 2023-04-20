using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSystem.Classes
{
    internal class EMailBox
    {
        public string Subject { get; set; }
        public string Text { get; set; }
        public string From { get; set; }
        public bool Status { get; set; } //unread or read true olanda unread olur

        public EMailBox(string subject, string text, string from)
        {
            Subject = subject;
            Text = text;
            From = from;
            Status = true;
        }
    }
}
