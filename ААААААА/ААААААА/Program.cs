using System;

namespace ААААААА
{
    public class Car //изменения внёс
    {
        public string name;
        public int year;
        public int mileage;
        public int price;
        public Car(string _name, int _year, int _mileage, int _price) // Ввод значений при объявлении класса
        {
            name = _name;
            year = _year;
            mileage = _mileage;
            price = _price;
            Display();
        }
        public void Display()
        {
            Console.WriteLine("Название:" + name + "\n" + "Год производства:" + year + "\n" + "Пробег" + mileage + "\n" + "Цена" + price + "$"); // Вывод
        }
        public class Animal
        {
            public int age;
            public string name;
            public string breed;
            public int price;
            public Animal(int _age, string _name, string _breed, int _price)
            {
                age = _age;
                name = _name;
                breed = _breed;
                price = _price;
                Display();
            }
            public void Display()
            {
                Console.WriteLine("Возраст:" + age + "\n" + "Имя:" + name + "\n" + "Порода" + breed + "\n" + "Цена" + price + "$");
            }
        }
        public class Home
        {
            public int price;
            public int rooms;
            public int area;
            public string European_quality_repair;

            public Home(int _price, int _rooms, int _area, string _European_quality_repair)
            {
                price = _price;
                rooms = _rooms;
                area = _area;
                European_quality_repair = _European_quality_repair;
            }
            public void Display()
            {
                Console.WriteLine("Цена:" + price + "\n" + "Кол-во комнат" + rooms + "\n" + "Площадь" + area+"м/кв" + "\n" + "Евроремонт" + European_quality_repair);
            }
        }
        public class telephone
        {
            public int price;
            public string diagonal;
            public int memory;
            public int Battery;

            public telephone(int _price, string _diagonal, int _memory, int _Battery)
            {
                price = _price;
                diagonal = _diagonal;
                memory = _memory;
                Battery = _Battery;
                Display();
            }
            public void Display()
            {
                Console.WriteLine("Цена:" + price + "\n" + "Диагональ" + diagonal + "\n" + "Объем внутренней памяти" + memory + "\n" + "Объем батареи" + Battery + "mAh");
            }
        }
            public class PC
            {
                public int price;
                public string cpu;
                public string gpaphics_card;
                public int ram;

                public PC(int _price, string _cpu, string _gpaphics_card, int _ram)
                {
                    price = _price;
                    cpu = _cpu;
                    gpaphics_card = _gpaphics_card;
                    ram = _ram;
                    Display();
                }
                public void Display()
                {
                    Console.WriteLine("Цена:" + price + "\n" + "Процессор" + cpu + "\n" + "Видеокарта" + gpaphics_card + "\n" + "ОЗУ" + ram + "Gb");
                }
            }
        

        public class Program
        {
            static void Main(string[] args)
            {
                Car VAZ_2109 = new Car("ВАЗ 2109", 1999, 125351, 60000);
                Car Mercedes = new Car("gelentvagen пятьИпять", 2020, 0,20000000 );
                Animal Шанни = new Animal(2, "Шанни", "Шотландская вислоухая", 15000);
                Animal Алтус = new Animal(5, "Алтус", "Немецкая овчарка", 0);
                Home ЦАО= new Home(60000000, 7, 150, "Лухари");
                Home СЗАО = new Home(6000000, 3, 67, "Хороший Середнячок");
                telephone Xiaomi = new telephone(20000, "6,1", 6, 5500);
                telephone Iphone = new telephone(60000, "5,9", 4, 4290);
                PC HyperPC = new PC(1000000000,"селерон какой-нибудь", "nvidia gt710", 2);
                PC Регард = new PC(65000, "AMD ryzen 5 2600", "AMD 5600xt", 16);
                Console.ReadLine();
            }
        }
    }
}
   

