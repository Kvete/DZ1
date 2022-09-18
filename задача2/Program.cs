/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/
Console.WriteLine("give me number1");
int number1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("give me number2");
int number2=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("give me number3");
int number3=Convert.ToInt32(Console.ReadLine());

if (number1>=number2)
    {
    if (number1>=number3)
        Console.WriteLine($"max number={number1}, midle number={number3}, min number={number2}");
    else 
        Console.WriteLine($"max number={number3}, midle number={number1}, min number={number2} ");
    }
else
    {
    if (number2>=number3)
        Console.WriteLine($"max number={number2}, midle number={number3}, min number={number1}");
    else 
        Console.WriteLine($"max number={number3}, midle number={number2}, min number={number1}");
    }