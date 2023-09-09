//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

int[] GenerateArray(int Lenght, int minValue, int maxValue)
{
    int[] array = new int[size];
    Random random = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(minValue, maxValue + 1);
    }
   
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    } 
    Console.Write("]");
}

int SumEvenIndex(int[] array)
{
    int i = 1;
    int sum = 0;
    while(i < array.Length)
    {
        sum = sum + arr[i];
        i = i + 2; 
    }   
    return sum;
}

int[] array = CreateArrayRndInt(4, -50, 100);
PrintArray(array);

int result = SumEvenIndex(array);
Console.WriteLine();
Console.WriteLine($"Сумма чисел на нечетных позициях -> {result}");
Console.WriteLine();