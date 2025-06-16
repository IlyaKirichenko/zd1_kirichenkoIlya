using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace zd1_KirchenkoIlya
{
    class Cat
    { 
        // Приватные поля для хранения данных
        private string name;
        private double weight;

        // Свойство для имени с проверкой
        public string Name
        {
            get { return name; }
            set
            {
                // Проверка что имя состоит только из букв
                bool OnlyLetters = true;
                foreach (var ch in value)
                {
                    if (!char.IsLetter(ch))
                    {
                        OnlyLetters = false;
                    }
                }

                if (OnlyLetters)
                {
                    name = value;
                }
                else
                {
                    Console.WriteLine($"{value} - неправильное имя!!!");
                }
            }
        }

        // Свойство для веса с проверкой
        public double Weight
        {
            get { return weight; }
            set
            {
                // Вес должен быть больше 0
                if (value > 0)
                {
                    weight = value;
                }
                else
                {
                    Console.WriteLine($"{value} - некорректный вес!");
                }
            }
        }

        // Конструктор класса
        public Cat(string CatName, double СatWeight)
        {
            Name = CatName;
            Weight = СatWeight;
        }

        // Метод для "мяуканья" кота
        public void Meow()
        {
            Console.WriteLine($"{Name} (вес: {Weight} кг): МЯЯЯУ!!!");
        }
    }
}