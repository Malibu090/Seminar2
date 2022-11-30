Console.Clear();
int randomDigit = new Random().Next(10, 100); //случайное число от 10 до 99 (если в коцне поставить"]" то будет до 100)
Console.WriteLine("Случайное число " +randomDigit);

int ostatok = randomDigit%10; // остаток от деления на 10
Console.WriteLine("Последняя цифра " +ostatok);

int firstDigit = randomDigit / 10; //первая цифра от деления на 10
Console.WriteLine("Первая цифра " +firstDigit);

int max = firstDigit; //задаем переменную макс равную первой цифре

if (ostatok > firstDigit) // проверяем условие, первая ли цифра максимальная?
    max = ostatok; // если нет, то объявляем вторую максимальной

Console.WriteLine("Максимальная цифра " +max);