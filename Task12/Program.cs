// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
// 16, 4 -> кратно
// 34, 5 -> не кратно, остаток 4
Console.Clear();
Console.WriteLine("Input number one ");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("Input number two ");
int numberB = int.Parse(Console.ReadLine());

if (numberB % numberA == 0)
{
    Console.WriteLine("кратно ");
}
else Console.WriteLine("не кратно, остаток " + numberB % numberA);