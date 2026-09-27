using System;

namespace CSharpBasicsLab
{
    // ===== 1. Типи даних =====
    class DataTypesDemo
    {
        public void ShowTypes()
        {
            int number = 10;
            double pi = 3.14159;
            char letter = 'A';
            string text = "Hello, C#";
            bool isTrue = true;

            Console.WriteLine("=== Типи даних ===");
            Console.WriteLine($"int: {number}, double: {pi}, char: {letter}");
            Console.WriteLine($"string: {text}, bool: {isTrue}");
        }
    }

    // ===== 2. Клас + модифікатори доступу =====
    class Person
    {
        private string name;          // private
        public int Age { get; set; }  // public property

        public Person(string name, int age)
        {
            this.name = name;
            Age = age;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Ім'я: {name}, Вік: {Age}");
        }
    }

    // ===== 3. Структура =====
    struct Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void Show()
        {
            Console.WriteLine($"Точка: ({X}, {Y})");
        }
    }

    // ===== 4. Інтерфейс =====
    interface IGreetable
    {
        void Greet();
    }

    class Student : IGreetable
    {
        public string Name { get; set; }

        public void Greet()
        {
            Console.WriteLine($"Привіт, я студент {Name}!");
        }
    }

    // ===== 5. Узагальнення (Generics) =====
    class Box<T>
    {
        private T value;

        public void Set(T val) => value = val;
        public T Get() => value;
    }

    // ===== 6. Головна програма =====
    class Program
    {
        static void Main(string[] args)
        {
            // Типи даних
            new DataTypesDemo().ShowTypes();

            // Клас
            Console.WriteLine("\n=== Клас Person ===");
            Person p = new Person("Олена", 20);
            p.ShowInfo();

            // Структура
            Console.WriteLine("\n=== Структура Point ===");
            Point point = new Point(5, 10);
            point.Show();

            // Інтерфейс
            Console.WriteLine("\n=== Інтерфейс ===");
            Student s = new Student { Name = "Іван" };
            s.Greet();

            // Узагальнення
            Console.WriteLine("\n=== Узагальнення (Generics) ===");
            Box<int> intBox = new Box<int>();
            intBox.Set(42);
            Console.WriteLine($"Значення в Box<int>: {intBox.Get()}");

            Box<string> strBox = new Box<string>();
            strBox.Set("Привіт generics");
            Console.WriteLine($"Значення в Box<string>: {strBox.Get()}");

            // Анонімний тип
            Console.WriteLine("\n=== Анонімний тип ===");
            var anon = new { Name = "Анонім", Age = 25 };
            Console.WriteLine($"Анонімний об'єкт: {anon.Name}, {anon.Age}");

            // Винятки (Exceptions)
            Console.WriteLine("\n=== Обробка винятків ===");
            try
            {
                int zero = 0;
                int result = 10 / zero;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Помилка: {ex.Message}");
            }

            Console.WriteLine("\nПрограма завершена успішно.");
        }
    }
}
