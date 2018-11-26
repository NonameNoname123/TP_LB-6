using System;
using System.Collections.Generic;
using System.Text;
using ConsoleMenu;

namespace ConsoleApp1.Actions
{
    class ShowUser : IMenuable
    {

        public List<User> users;

        public ShowUser(List<User> users)
        {
            this.users = users;
        }

        public int MenuRun(int keyboard)
        {

            Console.WriteLine("Введите ID пользователя: ");
            int id = Convert.ToInt32(Console.ReadLine()) - 1;

            if (id >= users.Count)
            {
                Console.WriteLine("Нет такого пользователя");
            }
            else
            {
                Console.WriteLine("Имя: " + users[id].name);
                Console.WriteLine("Номер телефона :с " + users[id].phone);
            }

            return 0;
        }
    }
}
