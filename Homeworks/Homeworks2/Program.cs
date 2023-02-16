// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

// int ShowCount(int number)
// {
//     int dec = number / 10;
//     int sot = number / 100;
//     return dec - sot * 10;
// }

// int randomnumber = new Random().Next(100, 1000);
// Console.WriteLine(randomnumber);
// Console.WriteLine(ShowCount(randomnumber));

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6





// void Comeback(int num)
// {
//     string str = Convert.ToString(num);
//     if (num > 0)
//     {
//         Console.WriteLine(str[2]);
//     }
//     else
//     {
//         Console.WriteLine("Третьей цифры нет");
//     }
// }
// // int randomnumber = new Random().Next(100, 2_147_483_647);
// // Console.WriteLine(randomnumber);
// int num = 8369306;
// Comeback(num);


// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет


// void DayOff(int day)        
// { 
//     int num = day; 
//     if (num >= 1 && num <= 5) 
//         { 
//             Console.Write("Нет, это не выходной"); 
//         } 
//         else if (num >= 6 && num <= 7) 
//         { 
//             Console.Write("Да, это выходной"); 
//         }     
// }
// int randomnumber = new Random().Next(1, 7 + 1);
// Console.WriteLine(randomnumber);
// DayOff(randomnumber);



//
//
