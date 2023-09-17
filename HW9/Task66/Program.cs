//Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. 
//Выполнить с помощью рекурсии.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

Console.WriteLine("Введите первое натуральное число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе натуральное число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 < 1 || number2 < 1)
{
    Console.WriteLine("Ошибка ввода!");
    return;
}

int SumNumbers(int number1, int number2)
{
    if (number1 == number2) 
    {
        return number2;
    }  
    else if (number1 < number2)
    {
        return number2 + SumNumbers(number1, number2 - 1);
    }
    else 
    {
        return number2 + SumNumbers(number1, number2 + 1);
    }
}

Console.Write($"\nM = {number1}; N = {number2} - >");
Console.Write(SumNumbers(number1, number2));