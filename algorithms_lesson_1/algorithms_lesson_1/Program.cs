using System;
using System.Collections.Generic;

namespace algorithms_lesson_1
{
    class Program
    {
        public static bool getEqualsSum(char a, char b) 
        {
            if (a.Equals(b)) 
            {
                return true;
            }
            else return false;
        }
        static void Menu() 
        {
            Console.WriteLine("Сделаны задачи: 11, 12, 13, 14");
            Console.WriteLine("Введите номер задачи");
            int choice = int.Parse(Console.ReadLine());
            if (choice == 11) 
            {
                //void first() 
                //{
                //    Console.WriteLine("Введите люблое число, если хотите закончить, то введите '0'");
                //    string userNumber = Console.ReadLine();
                //    int choose = 1;
                //    int number = 0;
                //    while (choose != 0)
                //    {
                //        number = int.Parse(userNumber);
                //        string lastnum = userNumber[userNumber.Length - 1].ToString();
                //        if ("8" == lastnum) 
                //        {
                //            Console.WriteLine("hello"); 
                //        }
                //        else break;
                //        //int value = int.Parse(number);
                //    }
                //    Console.WriteLine("Вы вышли из программы");
                //}
            }
            if (choice == 12) 
            {
                Console.WriteLine("Введите первое число");
                int numOne = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите второе число");
                int numTwo = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите третье число");
                int numThree = int.Parse(Console.ReadLine());
                int maxNum = numOne > numTwo ? numOne : numTwo;
                maxNum = maxNum > numThree ? maxNum : numThree;
                Console.WriteLine("Максимальное число " + maxNum);
                Menu();
            }
            if (choice == 13)
            {
                Console.WriteLine("Генератор случайного числа от 1 до 100");
                Console.WriteLine("Как вы хотите сгенерировать число? 1 - функцией 'rand', 2 - без функции rand");
                int localChoice = int.Parse(Console.ReadLine());
                if (localChoice == 1) 
                {
                    Random random = new Random();
                    Console.WriteLine("Ваше число " + random.Next(0,100));
                }
                if (localChoice == 2) 
                {
                    Console.WriteLine("Ваше число " + 100 / Convert.ToInt64(DateTime.Now.ToString("ss")));
                }
            }
            if (choice == 14)
            {
                Console.WriteLine("Введите целое, положительное число, а программа выведет все автоморфные числа не больше чем ваше число");
                string value = Console.ReadLine(); // есть число в строке
                int counter = 1;
                int firstValue = int.Parse(value); // есть число 
                int secondValue = firstValue * firstValue; // есть квадрат числа
                string secValuestr = secondValue.ToString(); // есть число в квадрате в строке
                bool [] arrTrue = new bool[value.Length]; // логический массив 
                for (int i = 0; i < firstValue; i++)
                {
                    for (int j = 0; j < value.Length; j++)
                    {
                        arrTrue[j] = getEqualsSum(value[value.Length - counter], secValuestr[secValuestr.Length - counter]);
                        if (arrTrue[i] == false) { break; }
                        else
                        {
                            Console.WriteLine("Число " + j + " входит"); // здесь остановился, надо делать автоморфные числа пока не достигнешь N
                            counter++;
                        }
                    }
                    Console.ReadKey();
                }
                
            }
            else if (choice != 11 && choice != 12 && choice != 13 && choice != 14)
            {
                Console.WriteLine("Неудалось распознать номер");
                Menu();
            }
            else 
            {
                Menu();
            }

            
        }
        static void Main(string[] args)
        {
            Menu();
        }
    }
}
