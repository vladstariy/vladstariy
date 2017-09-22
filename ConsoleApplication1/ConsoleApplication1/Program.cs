using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class User : IComparable<User>
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
            if (this.login.Length > other.login.Length)
            {
                return 1;
            }
            if (this.login.Length < other.login.Length)
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
            //создать класс user c закрытыми полями login и password.перегрузить метод Icomparable стандартного унаследованного интерфейса Icomparable,который сравнивает пользователей по login и password.Создат три пользователя и сравнить их.
            User u1 = new User("user1", "pass1");
            User u2 = new User("user123", "pass2");
            User u3 = new User("user1", "pass3");

            if (u1.CompareTo(u2) == 1)
            {
                Console.WriteLine("Длина логина у первого больше");
            }
            if (u1.CompareTo(u2) == -1)
            {
                Console.WriteLine("Длина логина у второго больше");
            }
            if (u1.CompareTo(u3) == 0)
            {
                Console.WriteLine("Длины одинаковые");
            }



        }
    }
}
