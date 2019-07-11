using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AstraPlat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<AstraPlatCard> cards = new List<AstraPlatCard>();
            bool isExit = false;
            int menu;
            int cardId;
            int cash;
            while (!isExit)
            {
                Console.Clear();
                Console.WriteLine("1 - Купить карту");
                Console.WriteLine("2 - Валидация");
                Console.WriteLine("3 - Пополнить счёт");
                Console.WriteLine("0 - Выход");
                menu = Convert.ToInt32(Console.ReadLine());
                switch (menu)
                {
                    case 0: isExit = true; break;
                    case 1:
                        AstraPlatCard tmp = new AstraPlatCard();
                        Console.Clear();
                        Console.WriteLine($"Номер вашей карточки: {tmp.GetId()}");
                        cards.Add(tmp);
                        Console.Write("Нажмите любую клавишу что бы продолжить");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Доступные карты:");
                        ShowCards(ref cards);
                        Console.Write("Введите номер вашей карточки: ");
                        cardId = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < cards.Count; i++)
                        {
                            if (cards[i].GetId() == cardId)
                            {
                                if (cards[i].Valid())
                                {
                                    Console.WriteLine("Валидация успешна!");
                                }
                                else
                                {
                                    Console.WriteLine("Ошибка! Не хватает денег!");
                                }
                                break;
                            }
                            else if (i == cards.Count - 1)
                            {
                                Console.WriteLine("Такой карты не существует!");
                            }
                        }
                        Console.Write("Нажмите любую клавишу что бы продолжить");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Доступные карты:");
                        ShowCards(ref cards);
                        Console.Write("Введите номер вашей карточки: ");
                        cardId = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < cards.Count; i++)
                        {
                            if (cards[i].GetId() == cardId)
                            {
                                Console.Write("Введите сумму для пополнения(максимальная сумма за раз = 10тыс. тнг): ");
                                cash = Convert.ToInt32(Console.ReadLine());
                                if (cards[i].Refill(cash))
                                {
                                    Console.WriteLine("Пополнение успешно!");
                                }
                                else
                                {
                                    Console.WriteLine("Ошибка! Неккоректный ввод!");
                                }
                                break;
                            }
                            else if (i == cards.Count - 1)
                            {
                                Console.WriteLine("Такой карты не существует!");
                            }
                        }
                        Console.Write("Нажмите любую клавишу что бы продолжить");
                        Console.ReadKey();
                        break;
                    default:
                        Console.Write("Неккоректно выбран пункт меню! Пожалуйста, выберите одну из списка!(нажмите любую клавишу что бы продолжить)");
                        Console.ReadKey();
                        break;
                }
            }
        }
        static void ShowCards(ref List<AstraPlatCard> cards)
        {
            for (int i = 0; i < cards.Count; i++)
            {
                Console.WriteLine($"ID: {cards[i].GetId()} - {cards[i].GetWallet()}тг");
            }
        }
    }
}
