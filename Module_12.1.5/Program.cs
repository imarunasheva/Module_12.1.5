using System;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Module_12._1._5
{
    class Program
    {
        private static bool isPremium;
        private static readonly List<User> users = [];

        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.Write("Введите логин: ");
                    string login = Console.ReadLine();

                    Console.Write("Введите имя: ");
                    string name = Console.ReadLine();

                    Console.Write("У вас есть премиум-подписки да/нет: ");
                    string answerPremium = Console.ReadLine();

                    if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(answerPremium))
                    {
                        throw new ArgumentNullException("Значения логин/пароль/наличие подписки не могут быть пустыми");
                    }

                    if (answerPremium != "Да" && answerPremium != "да" && answerPremium != "Нет" && answerPremium != "нет")
                    {
                        throw new FormatException("Укажите наличие подписки (Да или Нет)");
                    }

                    if (answerPremium == "Да" || answerPremium == "да")
                    {
                        isPremium = true;
                    }
                    else
                    {
                        isPremium = false;
                    }

                    User user = new(login, name, isPremium);
                    users.Add(user);
                    user.Greetings();
                    user.Advertisements();

                    Console.WriteLine();
                }
                catch (ArgumentNullException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine();
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine();
                }
            }
        }
    }
}