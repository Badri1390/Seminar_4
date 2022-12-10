// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

System.Console.Write("Введите число A: ");
int a = inputNumber();
System.Console.Write("Введите число B: ");
int b = inputNumber(); 
int res = Lite(); 
System.Console.WriteLine(res);

int Lite()
{
    int sum = 1;
    for (int i = 0; i < b; i++)
    {
        sum = sum * a;
    }
    return sum;
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