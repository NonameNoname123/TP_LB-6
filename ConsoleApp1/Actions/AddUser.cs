using ConsoleMenu;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Actions
{
    class AddUser : IMenuable
    {
        public List<User> users;

        public AddUser(List<User> users)
        {
            this.users = users;
        }

        public int MenuRun(int keyboard)
        {
            try
            {
                Console.WriteLine("Введите имя нового пользователя: ");
                string name = Console.ReadLine();
                if (name.Length == 0)
                {
                    throw new Exception("Length must be not null!");
                }
                Console.WriteLine("Телефон: ");
                users.Add(new User(name, Console.ReadLine()));
            }
            catch(Exception ex)
            {
                Program.logger.Error(ex, "Error in menurun method");
            }
            return 0;
        }
    }
}
