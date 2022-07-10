using System;

namespace HomeWork_Modul_3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Приветствую Вас в игре!");
            Console.WriteLine("Немного о правилах:" +
                                "\nДля карт с числовым номиналом необходимо ввести цифру;" +
                                "\nДля 'картинок' следует принять обозначения латинскими буквами:" +
                                "\nВалет = J" +
                                "\nДама = Q" +
                                "\nКороль = K" +
                                "\nТуз = T");
            Console.WriteLine("Сколько карт у вас на руках? Введите количество карт: ");
            int cards = int.Parse(Console.ReadLine()); // cards - количество карт на руках
            int cardsValue = 0; // Сумма карт на руках

            for (int i = 1; i <= cards; i++)
            {
                Console.Write($"Введите номинал {i}-й карты ");
                string cardNominal = Console.ReadLine(); // Номинал карты

                switch (cardNominal)
                {
                    case "2":
                    case "3":
                    case "4":
                    case "5":
                    case "6":
                    case "7":
                    case "8":
                    case "9":
                    case "10":
                        cardsValue += int.Parse(cardNominal);
                        break;
                    case "J":
                    case "Q":
                    case "K":
                    case "T":
                        cardsValue += 10;
                        break;
                    default:
                        Console.WriteLine("Допустимые значения для ввода: 2-10, J, Q, K, T");
                        Console.Write($"Введите номинал {i}-й карты ");
                        cardsValue += int.Parse(Console.ReadLine());
                        break;
                }

            }

            Console.WriteLine("Сумма карт на руках: " + cardsValue);
            Console.ReadKey();
        }
    }
}
