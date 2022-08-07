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

Console.Write("Write number 1: ");
int n = Convert.ToInt32(Console.ReadLine());;
Console.Write("Write number 2: ");
 int m = Convert.ToInt32(Console.ReadLine());;
for (int i = n; i <= m; i++)
        
 if (i % 2 == 0) 
            
 Console.Write(i + "Четные числа ");
