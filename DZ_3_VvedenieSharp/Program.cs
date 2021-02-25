using System;

namespace DZ_3_VvedenieSharp
{
    class Program
    {//Написать программу — телефонный справочник — создать двумерный массив 5*2, хранящий список телефонных контактов: 
     //первый элемент хранит имя контакта, второй — номер телефона/e-mail.

        static void Main(string[] args)
        {
            string[,] phoneBook = new string[5, 2] { 
                {"Alex", "5483621/mail" },
                {"Rudi", "873484/mailnext"}, 
                {"Коляныч" , "секретно"},
                {"Gloria" , "7441216"},
                {"Atskiy_Satana", "666"} };
        }
    }
}
