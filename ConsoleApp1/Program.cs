using System;
using System.Collections.Generic;
using ConsoleApp1.Actions;
using ConsoleMenu;
using NLog;
using NLog.Fluent;
//using log4net;
//using log4net.Config;
//[assembly: log4net.Config.XmlConfigurator(ConfigFile = "/log4net.config.xml", Watch = true)]


namespace ConsoleApp1
{

    class Program
    {
        public static Logger logger = LogManager.GetCurrentClassLogger();

        //private static readonly ILog log = LogManager.GetLogger(typeof(Program));
        //private static readonly log4net.ILog _logger = log4net.LogManager.GetLogger(typeof(Program));
        static void Main(string[] args)
        {


            List<User> users = new List<User>();
            users.Add(new User("Марсик", "324-978"));
            users.Add(new User("Густав", "02"));
            users.Add(new User("Тимоша", "324-978"));

            Menu mainMenu = new Menu("Основное меню");


            mainMenu.AddEl(new ElMenu("Список пользователей",new PrintUsers(users)));

            mainMenu.AddEl(new ElMenu("Данные пользователя", new ShowUser(users)));

            mainMenu.AddEl(new ElMenu("Удалить пользователя", new RemoveUser(users)));

            mainMenu.AddEl(new ElMenu("Добавить пользователя", new AddUser(users)));


            mainMenu.MenuRun(0);


        }
    }
}
