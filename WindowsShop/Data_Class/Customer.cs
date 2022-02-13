using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsShop.Data_Class
{
    public class Customer
    {
        public string FullName { set; get; }
        public string NumberPhone { set; get; }
        public string Email { set; get; }

        public string NationalCode { set; get; }
        public string Password { set; get; }
        public Factor Factor;
        private int RandomID()
        {
            System.Random random = new Random();
            return random.Next(0, int.MaxValue);
        }

        public Customer(string fulname, string numberph, string nationalcode, string email, string pas)
        {
            Factor = new Factor(RandomID());
            FullName = fulname;
            NumberPhone = numberph;
            NationalCode = nationalcode;
            Email = email;
            Password = pas;
        }
        //public Customer()
        //{
        //    Factor = new Factor(RandomID());
        //}
    }
}
