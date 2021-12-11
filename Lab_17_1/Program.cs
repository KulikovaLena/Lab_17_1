using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_17_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Console.Write("Введите номер счета ");
            try
            {
                string number = Convert.ToString(Console.ReadLine());
                Account<string> account1 = new Account<string>();
                {
                    account1.Print(number);
                };
            }
            catch
            {
                int number = Int32.Parse(Console.ReadLine());
                Account<int> account1 = new Account<int>();
                {
                    account1.Print(number);
                };
            }
            Console.ReadKey();
        }
    }
    class Account<T>
    {
        
        public T Number { get; set; }
        int sum;
        public int Sum
        {
            set
            {
                if (value > 0)
                {
                    sum = value;
                }
                else
                {
                    Console.WriteLine("Счет должен быть больше 0");
                }     
            }
        }
        public string Name { get; set; }
        public Account()
        {
            
        }
        public Account(T number, int sum, string name)
        {
            Number = number;
            Sum = sum;
            Name = name;
        }
        public void Print (T number)
        {
            Console.Write("Введите баланс ");
            int sum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите ФИО ");
            string name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Номер счета: {0}\nБаланс: {1}\nФИО: {2}", number, sum, name);
        }
    }
}
