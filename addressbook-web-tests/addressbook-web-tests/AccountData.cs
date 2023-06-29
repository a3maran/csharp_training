using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAddressbookTests
{
    internal class AccountData
    {
        //значения
        private string username;
        private string password;
        //конструктор, для быстрого создания объектов класса AccountData
        public AccountData (string username, string password)
        {
            this.username = username; //полю присваиваем значение, которое передано, как параметр 
            this.password = password;
        }
        //свойства значений
        public string Username
        {
            //возвращает значение поля
            get
            {
                return username;
            }
            //присваивает значение поля
            set
            {
                username = value;
            }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }

        }
    }
}

