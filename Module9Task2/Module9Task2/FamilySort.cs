using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module9Task2
{
    internal class FamilySort
    {
        public delegate void SortedDelegate(List<string> str);
        public event SortedDelegate sortEventA;
        public event SortedDelegate sortEventB;
        public List<string> StrList {  get; set; }
        public FamilySort(List<string> str)
        {
            StrList = str;
        }

        public void EnterNum(int i)
        {
            try
            {
                if (i == 1)
                {                   
                    sortEventA?.Invoke(StrList);
                }
                else if(i == 2)
                {
                    sortEventB?.Invoke(StrList);
                }
                else
                {
                    throw  new MyException("Введено не корректное число.Попробуйте ввести 1 или 2.");
                   
                }
            }
            catch (MyException ex)
            {
                Console.WriteLine();
                Console.WriteLine(ex.Message);
            }           

        }

    }



}
