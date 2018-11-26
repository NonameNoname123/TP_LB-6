using System;
using System.Collections.Generic;
using System.Text;
using ConsoleMenu;

namespace ConsoleApp1
{
    class PrintUsers : IMenuable
    {
        public List<User> users;

        public PrintUsers(List<User> users)
        {
            this.users = users;
        }

        public int MenuRun(int keyboard)
        {
            for(int i=0; i<users.Count; i++){
                Console.WriteLine((i+1) + ") " + users[i].name);
            }
            return 0;
        }
    }
}
