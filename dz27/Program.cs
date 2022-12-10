//  Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


System.Console.WriteLine("Введите число");
int num = inputNumber();
int summa = Auto();
Console.WriteLine(summa);

int Auto()
{
    int s = 0;
    while (num > 0)
    {
        s = s + num % 10;
        num = num / 10;
    }
    return s;
}

int inputNumber()
{
    int number;
    string text;

    while (true)
    {
        text = Console.ReadLine();
        if (int.TryParse(text, out number))
        {
            break;
        }
        Console.WriteLine("не удалось распознать число, попробуйте еще раз.");
    }
    return number;
}