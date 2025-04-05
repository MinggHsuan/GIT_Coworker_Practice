using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GIT協作練習.Services
{
    internal class login
    {
        public int number;
        public string name;
        public string phone;
        public void LoginModel(int number, string name, string phone)
        {
            this.number = number;
            this.name = name;
            this.phone = phone;
        }
    }
}
