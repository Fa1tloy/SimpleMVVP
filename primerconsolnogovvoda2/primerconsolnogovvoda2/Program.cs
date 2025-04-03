using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace primerconsolnogovvoda2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*string name;
            //заголовок консольного окна
            Console.Title="Давайте познакомимся?";

            //Сообщение в консоли
            Console.WriteLine("Введите свое имя");
            name = Console.ReadLine();
            string txt = "Очень приятно "  + name + "!";
            Console.Title = "Знакомство состоялось";
            Console.WriteLine(txt);

            Console.WriteLine("Вы хотите открыть папку Анапа2023 ?");
            Console.WriteLine("1 - ДА");
            Console.WriteLine("2 - нет");


            int x = Int32.Parse(Console.ReadLine());

            if (x == 1)
            {
                string filepath = "C:\\questions.txt.txt";
                Process.Start(filepath);
            }
            else
            {
                Environment.Exit(0);
            }*/

            ////////////////////////////

            /* string res, txt;
             int year = 2025, age, born;

             res = Interaction.InputBox("В каком году вы родились", "Год рождения?","", 2);
             if (int.TryParse(res, out int number) == true)
             {
                 born = Int32.Parse(res);
                 age = year - born;
                 txt = $"Тогда вам {age} лет";
                 MessageBox.Show(txt, "Возраст");
             }
             else if (int.TryParse(res, out int number2) == false)
             {
                string txtr = "Введите год рождения , например: 2006";
                 MessageBox.Show(txtr, "Возраст");
                 return;
             }*/
            /////////////////////
            /*string name;
            string sourname;

            Console.Write("Введите свое имя:");
            name = Console.ReadLine();
            Console.Write("Введите свою фамилию:");
            sourname = Console.ReadLine();

            Console.WriteLine("Приятно познакомится "+sourname+" "+ name);*/
            //////////////////////////
            /* string name;
             string age;

             name = Interaction.InputBox( "Введите свое имя","Имя");
             age = Interaction.InputBox("Введите свой возраст");

             string txt = $"Приятно познакомится  {age}-летний {name} !  ";
             MessageBox.Show(txt);*/

            /* int number, reminder;


             number = Int32.Parse(Interaction.InputBox("Введите целое число", "Проверка"));
             reminder = number % 2;
             string txt = "вы ввели";
             txt += (reminder == 0 ? "XTNYJT" : "YTXTNYJT");
             MessageBox.Show(txt);*/
            /* int numbers, 
                 hundreds;

             numbers = Int32.Parse(Interaction.InputBox("Введите целое число",
                 "Количество сотен"));
             hundreds = numbers / 100 % 10;
             string txt = "В это числе " + hundreds + " сотен";
             MessageBox.Show(txt);*/


            /* int number, reminder;
             number = Int32.Parse(Interaction.InputBox("Введите число","Проверка деления нацело на число 3"));

             reminder = number % 3;
             string txt = "Вы ввели число " + number;
             txt += (reminder == 0 ? " ,которое делится на 3 без остатка":
                 "  ,которое делится на 3 с остатком");
             MessageBox.Show(txt);*/
            ///////////////////////////////
            //Напишите программу, которая проверяет, удовлетворяет ли введенное 
            // пользователем число следующим критериям: при делении на 5 в остатке
            //получается 2, а при делении на 7 в остатке получается 1.


            /*int number, reminder, reminder2;
            number = Int32.Parse(Interaction.InputBox("Введите число", 
                "Проверка деления "));
            reminder = number % 5;
            reminder2 = number % 7;
            string txt = "Данное число";
            txt +=( reminder == 2 & reminder2 ==1 ? "при делении на 5 в остатке дает 2 а при делении на 7 получается 1" +
                "" : " при делении на 5 и 7 дает остаток");
            MessageBox.Show(txt);*/

           // Напишите программу, которая проверяет, сколько тысяч во введен
            //ном пользователем числе(определяется четвертая цифра справа в деся
             //тичном представлении числа).



           /* int number, southand;
            number = Int32.Parse(Interaction.InputBox("Введите число", 
                "Проверка соответствия "));
            southand = number/1000 % 1000;
       
            string txt = "Данное число содержит "+ southand + " тысяч";
        
            MessageBox.Show(txt);*/



            Console.ReadKey();

            
        }
    }
}
