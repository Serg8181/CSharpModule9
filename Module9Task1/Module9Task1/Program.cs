using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Создайте свой тип исключения.
  Сделайте массив из пяти различных видов исключений, включая собственный тип исключения.
  Реализуйте конструкцию TryCatchFinally,
  в которой будет итерация на каждый тип исключения (блок finally по желанию).
  В блоке catch выведите в консольном сообщении текст исключения.*/

namespace Module9Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Exception[] ex =
            {
                new ArgumentNullException(),
                new DirectoryNotFoundException(),
                new DriveNotFoundException(),
                new FormatException(),
                new MyException("Мое исключение")
            };
            foreach (var exception in ex)
            {
                try
                {
                    throw exception;

                }
                catch (Exception exp)
                {
                    Console.WriteLine(exp.Message);                    
                }
            }
            Console.ReadKey();
        }
    }

}
