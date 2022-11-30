// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

Console.Clear();
int randomDigit = new Random().Next(100, 1000); // Случайное трехзначное число
Console.WriteLine("Случайное трехзначное число " + randomDigit);

// int firstDigit = randomDigit / 100; // первая цифра
// Console.WriteLine("первая цифра числа " + firstDigit);

// int lastDigit = randomDigit % 10; // последняя цифра
// Console.WriteLine("последняя цифра числа " + lastDigit);

// Console.WriteLine("Число без второй цифры " + firstDigit + lastDigit);

int oneDigit = (randomDigit / 100) * 10 + randomDigit % 10; // выводит сумму первой и последней цифры
Console.WriteLine(randomDigit + " -> " + oneDigit);

