using System;

namespace DZ_3_VvedenieSharp
{
    class Program
    {//Написать программу, выводящую элементы двухмерного массива по диагонали.

        static void Main(string[] args)
        {
            string[,] myArray = new string[5 , 5];
            Random rndValue = new Random();

            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    myArray[i, j] = Convert.ToString(rndValue.Next(0, 600));
                }
                
            }

            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    Console.WriteLine($"Индекс {i},{j} = {myArray[i, j]}");
                }

            }

        }
    }
}
