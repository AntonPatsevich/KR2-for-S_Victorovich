using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp74
{
    class transport
    {
        public const string car = "Машина";
        public const string bus = "Автобус";
        public const string gooo = "Пешком";
        public transport()
        {

        }
        public void ch()
        {
            Console.WriteLine("Предложенные способы путешествия: " + car + " " + bus + " " + gooo + " ");
            Console.WriteLine("Выберите способ путешествия(не распространяется для круиза): ");
            int choose = Convert.ToInt32(Console.ReadLine());
            switch (choose)
            {
                case 1:
                    Console.Write("Вы выбрали способ поездки:{0}", car);
                    Console.WriteLine("Дополнительная плата не взымается.");
                    break;
                case 2:
                    Console.Write("Вы выбрали способ поездки:{0}", bus);
                    Console.WriteLine("Дополнительная плата взымается в размере 50р.");
                    break;
                case 3:
                    Console.Write("Вы выбрали способ поездки:{0}", gooo);
                    Console.WriteLine("Дополнительная плата не взымается.");
                    break;
                default: break;
            }
        }

    }
    class relax
    {
        public const string ekskurs = "Эксурсия";
        public const string shop = "Шопинг";
        public const string kruis = "Круиз";
        public const string healthing = "Оздоровление";
        public relax()
        {

        }
        public void ques()
        {
            Console.WriteLine("Предлагается следующий список путевок: ");
            Console.WriteLine(ekskurs);
            Console.WriteLine(shop);
            Console.WriteLine(kruis);
            Console.WriteLine(healthing);
        }
        public void ch()
        {
            Console.Write("Выберите путевку: ");
            int choose = Convert.ToInt32(Console.ReadLine());
            switch (choose)
            {
                case 1:
                    Console.WriteLine("Вы выбрали путевку:{0}", ekskurs);
                    break;
                case 2:
                    Console.WriteLine("Вы выбрали пуетвку:{0}", shop);
                    break;
                case 3:
                    Console.WriteLine("Вы выбрали путевку:{0}", kruis);
                    break;
                case 4:
                    Console.WriteLine("Вы выбрали путевку:{0}", healthing);
                    break;
                default: break;
            }
        }
    }
    class eat
    {
        public bool sfg = true;
        public eat()
        {

        }
        public void ea()
        {
            Console.WriteLine("Включить питание в путевку?");
            int choose = Convert.ToInt32(Console.ReadLine());
            switch (choose)
            {
                case 1:
                    Console.WriteLine("Питание:{0}", sfg);
                    break;
                case 2:
                    Console.WriteLine("Питание:{0}", !sfg);
                    break;
                default: break;
            }
        }
    }
    class days
    {
        
        public days()
        {

        }
        public void day()
        {
            Console.Write("Введите количество дней(1-30)");
            int day = Convert.ToInt32(Console.ReadLine());
            if (day > 0 & day < 30)
                Console.Write("Выбрано дня(ей): {0}", day);
            else { Console.Write("Такого не предоставляем."); }
            Console.ReadLine();
        }
        
        class Program
        {
            static void Main(string[] args)
            {
                Console.Write("Нашей компанией предлагается предлагается путевки :");
                relax r = new relax();
                r.ques();
                r.ch();
                transport t = new transport();
                t.ch();
                eat e = new eat();
                e.ea();
                days d = new days();
                d.day();
                Console.ReadLine();
            }
        }
    }
}
