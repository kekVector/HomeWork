﻿//Мария Хребтова, Дмитрий Блажевич, Юрий Яцунов
//Задача 0. 
//Вывести квадрат числа 

// int a = int.Parse(Console.ReadLine());
// Console.WriteLine($"Ваш квадрат числа {a} = {a*a}");





// Задача 1. 
//По двум заданным числам проверять является ли первое квадратом второго

// int a = 64;
// int b = 5;
// if (a == b * b)
// {
//     Console.WriteLine($" число {a} является квадратом {b}");
// }
// else
// {
//     Console.WriteLine($" число {a} неявляется квадратом {b}");
// }





//Задача 2. 
//Даны два числа. Показать большее и меньшее число

// int a = 27;
// int b = 35;
// if (a < b)
// {
//     Console.WriteLine("меньшее число" + a);
//     Console.WriteLine("большее число" + b);
// }
// else
// {
//     Console.WriteLine("меньшее число" + b);
//     Console.WriteLine("большее число" + a);
// }



//Задача 3. 
//По заданному номеру дня недели вывести его название

// int NumberWeek = int.Parse(Console.ReadLine());

// void Week(int date)
// {
//     if(date == 1)
//     {
//         Console.WriteLine("Сегодня понедельник");
//     }
//     else if(date == 2)
//     {
//         Console.WriteLine("Сегодня вторник");
//     }
//     else if(date == 3)
//     {
//         Console.WriteLine("Сегодня среда");
//     }
//     else if(date == 4)
//     {
//         Console.WriteLine("Сегодня четверг");
//     }
//     else if(date == 5)
//     {
//         Console.WriteLine("Сегодня пятница");
//     }
//     else if(date == 6)
//     {
//         Console.WriteLine("Сегодня суббота");
//     }
//     else if(date == 7)
//     {
//         Console.WriteLine("Сегодня воскресенье");
//     }
//     else 
//     {
//         Console.WriteLine("Такого дня нет");
//     }

// }
// Week(NumberWeek);




//Задача 4. 
//Найти максимальное из трех чисел 
// int[] A = new int[3];
// int index = 0;
// while (index < 3)
// {
//     A[index] = new Random().Next(1, 99);
//     Console.Write(" " + A[index]);
//     index++;
// }
// int max = A[0];
// for (int i = 1; i < 3; i++)
//     if (A[i] > max)
//     {
//         max = A[i];
//     }
// Console.WriteLine(" ");
// Console.WriteLine("максимальный элемент: " + max);






//Задача 5. 
// Написать программу вычисления значения функции y=sin(a) 
// double GetF(double a)
// {
//     return Math.Sin(a);
// }
// Console.WriteLine(GetF(6));





//Задача 6.
//Выяснить является ли число чётным
// int Number = new Random().Next(1,100);

// if(Number%2 == 0)
// {
//     Console.WriteLine($"Число {Number} четное");
// }
// else
// {
//     Console.WriteLine($"Число {Number} нечетное");

// }






//Задача 7. 
// Показать числа от -N до N 
// int a = int.Parse(Console.ReadLine());
// int b = a - 2 * a;
// for (int index = b; index <= a; index++)
// {
//     Console.Write(index + " ");
// }





//Задача 8.
//Показать четные числа от 1 до N

// Console.WriteLine("Введите число : ");

// int Num = int.Parse(Console.ReadLine());

// for(int i=2; i<= Num; i+=2)
// {
//     Console.Write(" " + i);
// }