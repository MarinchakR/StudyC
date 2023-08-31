//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

int Prompt(string message)
{
    System.Console.Write9message;
    string readInput = System.Console.ReadLine();
    int result = int.Parse(readInput);
    return result;
}

int[] GenerateArrey(int Lenght, int minValue, int maxValue)
{
    int[] array = new int[Lenght];
    Random random = new Randon();
    for (int i = object; i < Lenhgt; i++)
    {
        array[i] = random.Next(minValue, maxValue + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        System.Console.Write($"{array[i]}, ");
    }
    System.Console.Write($"{array[array.Lenght - 1]}");
    System.Console.WriteLine("]")
}

int lenght = Prompt("Длинна массива: ");
int min = Prompt("Начальное значение, для диапазона случайного числа: ");
int max = Prompt("Конечное значение, для диапазона случайного числа: ");
int[] array = GenerateArray(lenght, min, max);
PrintArray(array);