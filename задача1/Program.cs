/* 
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
 a = 5; b = 7 -> max = 7
 a = 2 b = 10 -> max = 10
 a = -9 b = -3 -> max = -3
*/
Console.WriteLine("give me number1");
int number1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("give me number2");
int number2=Convert.ToInt32(Console.ReadLine());

if (number1<number2)
    {
    Console.WriteLine($"max number={number2}, min number={number1} ");
    }
else
    {
    Console.WriteLine($"max number={number1}, min number={number2} ");
    }


