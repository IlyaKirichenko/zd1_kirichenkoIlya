using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zd1_KirchenkoIlya
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаем первого кота
            Console.WriteLine("Введите данные для первого кота:");
            Cat cat1 = CreateCatFromInput();
            // Создаем второго кота
            Console.WriteLine("\nВведите данные для второго кота:");
            Cat cat2 = CreateCatFromInput();

            // Выводим информации
            Console.WriteLine("\nРезультат:");
            cat1.Meow();
            cat2.Meow();
            Console.ReadKey();
        }

        // Метод для создания кота с вводом данных
        static Cat CreateCatFromInput()
        {
            Console.Write("Введите имя кота: ");
            string name = Console.ReadLine();

            double weight;
            // Цикл для корректного ввода веса
            while (true)
            {
                Console.Write("Введите вес кота (кг): ");
                if (double.TryParse(Console.ReadLine(), out weight))
                {
                    if (weight >= 1 && weight <= 20)
                    {
                        break; // Выход при правильном вводе
                    }
                    
                }
                Console.WriteLine("Некорректный ввод веса! Попробуйте еще раз.");
            }

            return new Cat(name, weight);
        }
    }
}
