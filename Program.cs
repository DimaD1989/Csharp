//Console.Write("Input first number: ");
//int num1 = Convert.ToInt32(Console.ReadLine());
//Console.Write("Input second number: ");
//int num2 = Convert.ToInt32(Console.ReadLine());
//if (num1 > num2 )
 //   Console.Write("First number is a max");
//else
  //  Console.Write("Second number is max");
 // Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

//Console.Write("Input first number:");
//int number1=Convert.ToInt32(Console.ReadLine());//3;
//Console.Write("Input second number:");
//int number2=Convert.ToInt32(Console.ReadLine());//2
//Console.Write("Input third number:");
//int number3=Convert.ToInt32(Console.ReadLine());//7;
//int max = number1;
//if (number2>max) max= number2;
//if (number3>max) max= number3;
//Console.WriteLine(" max number " + max );

// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

//4 -> да
//-3 -> нет
//7 -> нет

//Console.Write("Input first number:");
//int number1=Convert.ToInt32(Console.ReadLine()); //4
//if  ((double)number1%2==0)
//Console.Write(" Number1 - Четное");
//else
//Console.Write(" Number - Нечетное");

//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

//5 -> 2, 4
//8 -> 2, 4, 6, 8

// Console.Write("Write number 1: ");
// int n = Convert.ToInt32(Console.ReadLine());;
// Console.Write("Write number 2: ");
//  int m = Convert.ToInt32(Console.ReadLine());;
// for (int i = n; i <= m; i++)
       
//  if (i % 2 == 0) 
            
//  Console.Write(i + "Четные числа ");

// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1



// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

// Console.Write("Введи трёхзначное число: ");
// int num = new Random().Next(100,1000);
// int secondDigitNumber = num / 10 % 10;
// Console.WriteLine($"Вторая цифра числа {num} -> {secondDigitNumber}");

//  Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

// Console.WriteLine("Enter some number: ");
//  int Number = Convert.ToInt32(Console.ReadLine());
// int cycle = 0;

// while (cycle < Number) {
//     if (Number > 999) 
//     {
//         Number = Number / 10;
//     }
//      cycle++;
//  }

// if (Number > 99 && Number < 1000) 
// {
//     Console.Write("The third digit is: ");
//     Console.WriteLine(Number % 10);
// }

// else 
// {
//   Console.WriteLine("There's no third digit in your number.");
//  }

// Console.Write("Введи цифру, обозначающую день недели: ");
// int dayNumber = Convert.ToInt32(Console.ReadLine());

// void CheckingTheDayOfTheWeek (int dayNumber) {
//   if (dayNumber == 6 || dayNumber == 7) {
//   Console.WriteLine("(этот день выходной) -> да");
//   }
//   else if (dayNumber < 1 || dayNumber > 7) {
//     Console.WriteLine("это вообще не день недели");
//   }
//   else Console.WriteLine("(этот день не выходной) -> нет");
// }
// CheckingTheDayOfTheWeek(dayNumber);

