//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
int[] arr = Auto();
System.Console.WriteLine("[" + string.Join(" | ", arr) + "]");

int[] Auto()
{
    int[] arr = new int[8];
    Random rand = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(5, 99);
    }
    return arr;
}
