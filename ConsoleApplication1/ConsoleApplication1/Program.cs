using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class User : IComparable<User>
        //Артём,посмотри вк
    {
        public User(string login, string pass)
        {
            this.login = login;
            this.password = pass;
        }

        private string login;
        private string password;

        public int CompareTo(User other)
        {
            if ((this.login.Length + this.password.Length) > (other.login.Length + other.password.Length))
            {
                return 1;
            }
            if ((this.login.Length + this.password.Length) < (other.login.Length + other.password.Length))
            {
                return -1;
            }
            return 0;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            User u1 = new User("user1", "pass1");
            User u2 = new User("user123", "pass2");
            User u3 = new User("user1", "pass3");

            if (u1.CompareTo(u2) == 1)
            {
                Console.WriteLine("Первый пользователь");
            }
            if (u1.CompareTo(u2) == -1)
            {
                Console.WriteLine("Второй пользователь");
            }

            if (u2.CompareTo(u3) == -1)
            {
                Console.WriteLine("Второй пользователь");
            }
            else
            {
                Console.WriteLine("Третий пользователь");
            }



        }
    }
}
