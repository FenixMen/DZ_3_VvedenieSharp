using System;

namespace DZ_3_VvedenieSharp
{
    class Program
    {//Написать программу, выводящую введенную пользователем строку в обратном порядке (olleH вместо Hello).

        static void Main(string[] args)
        {
            Console.WriteLine("Введите любое слово/симвлы:");
            string userAnswer = Console.ReadLine();

            for (int i = userAnswer.Length -1; i >= 0; i--)
            {
                Console.Write(userAnswer[i]);
            }
        }
    }
}
