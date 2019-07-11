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
                }
            }
        }
    }
}
