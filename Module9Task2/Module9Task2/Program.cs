using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Задание 2
    Создайте консольное приложение, в котором будет происходить сортировка списка фамилий
    из пяти человек. Сортировка должна происходить при помощи события. 
    Сортировка происходит при введении пользователем либо числа 1 (сортировка А-Я),
    либо числа 2 (сортировка Я-А).
    Дополнительно реализуйте проверку введённых данных от пользователя через конструкцию TryCatchFinally
    с использованием собственного типа исключения.*/

namespace Module9Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> family =new List<string>();
            family.Add("Яковлев");
            family.Add("Горбунов");          
            family.Add("Булгаков");
            family.Add("Вопилин");
            family.Add("Аверин");

            FamilySort familySort = new FamilySort(family);

            familySort.sortEventA += MySortA;
            familySort.sortEventB += MySortB;            

            int num ;

            while(true)
            {
                Console.Clear();
                Console.WriteLine("Введите число 1(сортировка А-Я) или 2(сортировка Я-А): ");
                Console.WriteLine();
                try
                {
                    if (!int.TryParse(Console.ReadLine(), out num))
                    {
                        throw new MyException("Введено некоректное значение.Попробуйте ввести 1 или 2.");
                       
                    }
                    else
                    {
                        familySort.EnterNum(num);

                        Console.ReadKey();
                    }

                }
                catch (MyException ex)
                {
                    Console.WriteLine();
                    Console.WriteLine(ex.Message);
                    Console.ReadKey();
                }
               
            }
            
        }

        static void MySortA(List<string> str)
        {
            str.Sort();
            Console.WriteLine("_______________________________");
            Console.WriteLine("Список отсортирован  А - Я: ");
            Console.WriteLine();
            foreach (var item in str)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("_______________________________");
        }

        static void MySortB(List<string> str)
        {
            str.Sort();
            str.Reverse();
            Console.WriteLine("_______________________________");
            Console.WriteLine("Список отсортирован  Я - А:");
            Console.WriteLine();
            foreach (var item in str)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("_______________________________");
        }

    }
}
