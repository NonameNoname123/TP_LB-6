using System;
using System.Collections.Generic;
using System.Text;
using ConsoleMenu;

namespace ConsoleApp1.Actions
{
    class RemoveUser : IMenuable
    {

        public List<User> users;

        public RemoveUser(List<User> users)
        {
            this.users = users;
        }

        public int MenuRun(int keyboard)
        {

            Console.WriteLine("Введите ID пользователя: ");
            int id = Convert.ToInt32(Console.ReadLine())-1;

            if (id >= users.Count)
            {
                Console.WriteLine("Нет такого пользователя");
            } else
            {
                Console.WriteLine("Пользователь " + users[id].name + ". Действительно удалить? (YES = удалить): ");
                if ( Console.ReadLine().ToLower() == "yes")
                {
                    users.RemoveAt(id);
                    Console.WriteLine("Пользователь безвозвратно удалён :с ");
                } else
                {
                    Console.WriteLine("Действие отменено.");
                }
            }

            return 0;
        }
    }
}
