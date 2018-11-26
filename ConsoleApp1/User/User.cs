using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class User : ConsoleMenu.IMenuable
    {
        public string name;
        public string phone;

        public User(string name, string phone)
        {
            this.name = name;
            this.phone = phone;
        }

        public int MenuRun(int keyboard)
        {
            Console.WriteLine(name + " " + phone);

            return 0;
        }
    }
}
