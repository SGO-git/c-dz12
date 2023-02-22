// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int ReadInt(string text)
{
    System.Console.Write(text);
    return Math.Abs(Convert.ToInt32(System.Console.ReadLine()));
}

int Sum(int number)
{
    int result = 0;
    while (number >= 1)
    {
        result += number % 10;
        number /= 10;
    }
    return result;
}

int num = ReadInt("Imput number ");
System.Console.WriteLine(Sum(num));
