using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsShop.Data_Class
{
    public class Admin
    {
        public string FullName { set; get; }
        public string UserName { set; get; }
        public string Password { set; get; }
        public string NumberPhone { set; get; }
        public string Email { set; get; }
        public Admin(string username, string password)
        {
            UserName = username;
            Password = password;
        }
        public Admin(string fulname, string username, string email, string numberphone, string pas)
        {
            FullName = fulname;
            UserName = username;
            Email = email;
            NumberPhone = numberphone;
            Password = pas;
        }
    }
}
