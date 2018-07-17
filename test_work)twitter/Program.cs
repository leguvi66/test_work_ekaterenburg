using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace test_work_twitter
{
    class Program
    {


        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Меню:");
                Console.WriteLine("1. Отправить Твитт на Тест страницу.");
                Console.WriteLine("2. Просмореть статистику последних 5 твиттов у выбранног пользователя.");
                Console.WriteLine("3. Выход.");
                try
                {
                    int MenuNumber = int.Parse(Console.ReadLine());
                    switch (MenuNumber)
                    {
                        case 1:
                            Console.WriteLine("Введите текст Твитта:");
                            SendTwitte.Send(Console.ReadLine());
                            break;
                        case 2:
                            Console.WriteLine("Введите Id пользователя:");
                            Account.login = Console.ReadLine().Replace("@", "");
                            Account.ParceTwittes();
                            Console.WriteLine(Account.login);
                            if (Account.ListTwittes.Count != 0)
                            {
                                for (int i = 0; i < 5; i++)
                                    Console.WriteLine(Json_object.JsonTwittes(Account.ListTwittes[i]));
                            }
                            break;
                        case 3:
                            return;
                    }
                }
                catch { Console.WriteLine("Ошибка при выборе пункта меню!"); }
            }
        }
    }
}
