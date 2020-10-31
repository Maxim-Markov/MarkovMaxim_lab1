using System;
using System.Collections.Generic;
using System.Xml;

namespace Лабораторная1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Поддерживаемые команды: Editing(index),Add(),Removing(index),SeeOne(index),SeeAll()");
            TelBook.Add();
            TelBook.Add();
            TelBook.Add();
            TelBook.Removing(0);
            TelBook.SeeOne(0);
            TelBook.Editing(0);
             TelBook.SeeOne(0);
            TelBook.SeeAll();
            Console.WriteLine();
        }
        
    }

    public class TelBook
    {
        private static List<TelBook> book = new List<TelBook>();
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public char[] TelNum { get;

            private set;
            
             }
        public string Country { get; private set; }
        public TelBook()
        {
            FirstName = "Не определено";
            LastName = "Не определено";
            TelNum[0] = '8';
            for (int i = 1; i < TelNum.Length; i++)
                TelNum[i] = '0';
            Country = "Россия";
        }
        public TelBook(string firstName)
        {
            FirstName = firstName;
            LastName = "Не определено";
            char[] temp = new char[11];
            temp[0] = '8';
            for (int i = 1; i < 11; i++)
                temp[i] = '0';
            TelNum = temp;
            Country = "Россия";
        }
        public TelBook(string firstName,string lastName)
        {
            FirstName = firstName;
            LastName = lastName;

            char[] temp = new char[11];
            temp[0] = '8';
            for (int i = 1; i < 11; i++)
                temp[i] = '0';
            TelNum = temp;
            Country = "Россия";
        }
        public TelBook(string firstName, string lastName,string country)
        {
            FirstName = firstName;
            LastName = lastName;
            char[] temp = new char[11];
            temp[0] = '8';
            for (int i = 1; i < 11; i++)
                temp[i] = '0';
            TelNum = temp;
            Country = country;
        }
        public TelBook(string firstName, string lastName, char[] telNum)
        {
            FirstName = firstName;
            LastName = lastName;
            TelNum = telNum;
            Country = "Россия";
        }
        public TelBook(string firstName, string lastName, string country, char[] telNum)
        {
            FirstName = firstName;
            LastName = lastName;
           
                char[] temp = new char[11];
                
                for (int j = 1; j < 11; j++)
                    temp[j] = telNum[j];
                TelNum = temp;
            
            
            Country = country;
        }

        public static void Add()
        {
            Console.WriteLine("Что вы желаете добавить? Возможные варианты:\nИмя\nИмя,Фамилия\nИмя,Фамилия,Номер телефона\nИмя,Фамилия,Номер телефона,Страна\nИмя,Фамилия,Страна");
            string str = Console.ReadLine();
            while ((str != "Имя") && (str != "Имя,Фамилия") && (str != "Имя,Фамилия,Номер телефона") && (str != "Имя,Фамилия,Страна") && (str != "Имя,Фамилия,Номер телефона,Страна"))
            {
                Console.WriteLine("Запрос не распознан. Попробуйте ещё:");
                str = Console.ReadLine();
                
            }
            switch (str)
            {
                case "Имя":
                    {
                        Console.WriteLine("Введите имя");
                        
                        string str1 = Console.ReadLine();
                        TelBook b = new TelBook(str1);
                        book.Add(b);
                        break;
                    }
                case "Имя,Фамилия":
                    {
                        Console.WriteLine("Введите имя");
                        string str1 = Console.ReadLine();
                        Console.WriteLine("Введите фамилию");
                        string str2 = Console.ReadLine();
                        book.Add(new TelBook(str1, str2));
                        break;
                    }
                case "Имя,Фамилия,Номер телефона":
                    {
                        Console.WriteLine("Введите имя");
                        string str1 = Console.ReadLine();
                        Console.WriteLine("Введите фамилию");
                        string str2 = Console.ReadLine();
                        Console.WriteLine("Введите Номер телефона,вводите только цифры в формате 8XXXXXXXXXX");
                        char[] temp = new char[11];
                        str = Console.ReadLine();
                        bool isCorrect = false;
                        for (int i = 0; i < 11; i++)
                        {
                            
                            if (Int64.TryParse(str,out long number) == true)
                            {
                                isCorrect = true;
                            }
                        }
                        
                        while ((str.Length != 11)||(isCorrect == false))
                        {
                            Console.WriteLine("неверный формат номера, попробуйте ещё");
                            str = Console.ReadLine();
                           
                                if (Int64.TryParse(str, out long number) == true)
                                {
                                    isCorrect = true;
                                }
                            
                        }

                        for (int i = 0; i < 11; i++)
                        {
                            temp[i] = str[i];
                        }
                        book.Add(new TelBook(str1, str2, temp));
                        Console.WriteLine();
                        break;
                    }
                case "Имя,Фамилия,Номер телефона,Страна":
                    {

                        Console.WriteLine("Введите имя");
                        string str1 = Console.ReadLine();
                        Console.WriteLine("Введите фамилию");
                        string str2 = Console.ReadLine();
                        Console.WriteLine("Введите Номер телефона,вводите только цифры в формате 8XXXXXXXXXX");
                       
                        char[] temp = new char[11];
                        str = Console.ReadLine();
                        bool isCorrect = false;
                        

                            if (Int64.TryParse(str, out long number) == true)
                            {
                                isCorrect = true;
                            }
                        

                        while ((str.Length != 11) || (isCorrect == false))
                        {
                            Console.WriteLine("неверный формат номера, попроуйте ещё");
                            str = Console.ReadLine();
                            

                                if (Int64.TryParse(str, out long num) == true)
                                {
                                    isCorrect = true;
                                }
                            
                        }
                        for (int i = 0; i < 11; i++)
                        {
                            temp[i] = str[i];
                        }
                        Console.WriteLine("Введите страну");
                        string str3 = Console.ReadLine();

                        book.Add(new TelBook(str1, str2, str3, temp));
                        Console.WriteLine();
                        break;
                    }

                case "Имя,Фамилия,Страна":
                    {

                        Console.WriteLine("Введите имя");
                        string str1 = Console.ReadLine();
                        Console.WriteLine("Введите фамилию");
                        string str2 = Console.ReadLine();
                        
                        Console.WriteLine("Введите страну");
                        string str3 = Console.ReadLine();

                        book.Add(new TelBook(str1, str2, str3));
                        Console.WriteLine();
                        break;
                    }
            }
        }
        public static void Editing(int index)
        {
            if ((index < 0) || (index >= book.Count))
            {
                Console.WriteLine("Такого индекса нет!");
                return;
            }
            Console.WriteLine("Что вы желаете отредактировать? Возможные варианты:\nИмя,Фамилия,Номер телефона,Страна");
            string str = Console.ReadLine();
            while((str!="Имя")&&(str != "Фамилия") && (str != "Номер телефона") && (str != "Страна"))
            {
                
                Console.WriteLine("Запрос не распознан. Попробуйте ещё:");
                str = Console.ReadLine();
            }
            switch (str)
            {
                case "Имя":
                    {
                        Console.WriteLine("Введите имя");
                        book[index].FirstName = Console.ReadLine();
                        break;
                    }
                case "Фамилия":
                    {
                        Console.WriteLine("Введите фамилию");
                        book[index].LastName = Console.ReadLine();
                        break;
                    }
                case "Номер телефона":
                    {
                        Console.WriteLine("Введите Номер телефона,вводите только цифры в формате 8XXXXXXXXXX");

                        char[] temp = new char[11];
                        str = Console.ReadLine();
                        bool isCorrect = false;
                        for (int i = 0; i < 11; i++)
                        {

                            if (Int64.TryParse(str, out long number) == true)
                            {
                                isCorrect = true;
                            }
                        }

                        while ((str.Length != 11) || (isCorrect == false))
                        {
                            Console.WriteLine("неверный формат номера, попроуйте ещё");
                            str = Console.ReadLine();
                            

                                if (Int64.TryParse(str, out long number) == true)
                                {
                                    isCorrect = true;
                                }
                            
                        }
                        for (int i = 0; i < 11; i++)
                                temp[i] = str[i];
                          
                            
                            book[index].TelNum = temp;

                        
                        
                        break;
                    }
                case "Страна":
                    {
                        Console.WriteLine("Введите страну");
                        book[index].Country = Console.ReadLine();
                        break;
                    }
            }
            Console.WriteLine();
        }

        public static void Removing(int index)
        {
            if((index < 0)||(index >= book.Count))
            {
                Console.WriteLine("Такого индекса нет!");
                return;
            }
            book.RemoveAt(index);
        }

        public static void SeeOne(int index)
        {
            if ((index < 0) || (index >= book.Count))
            {
                Console.WriteLine("Такого индекса нет!");
                return;
            }
            Console.Write($"Имя: {book[index].FirstName},\nФамилия: {book[index].LastName}\nНомер телефона");
            for (int i = 0; i < 11; i++)
            {
                Console.Write(book[index].TelNum[i]);
            }
            Console.WriteLine($"\nСтрана: {book[index].Country}");
            Console.WriteLine();
        }

        public static void SeeAll()
        {
            for (int index = 0; index < book.Count; index++)
            {
                Console.WriteLine($"индекс в телефонной книге: {index}");
                Console.Write($"Имя: {book[index].FirstName},\nФамилия: {book[index].LastName}\nНомер телефона");
                for (int i = 0; i < 11; i++)
                {
                    Console.Write(book[index].TelNum[i]);
                }
                Console.WriteLine();
            }
            
           
        }
    }
}
