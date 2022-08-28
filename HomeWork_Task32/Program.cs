// Задача 34: Задайте массив случайными положительными трех значными числами
// написать программу которая покажет количество четных чисел.

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if(i < array.Length - 1)Console.Write($"{array[i]}, ");
        else Console.Write(array[i]);
    }
    Console.Write("]");  
    Console.WriteLine();
} 

int[] GetSumEven(int[] array)
{
    int sumEven = 0;
    
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0) sumEven ++;           ;
    }
    return new int[]{sumEven};
}

int[] arr = CreateArrayRndInt(4, 100, 999);
PrintArray(arr);
int[] sumEven = GetSumEven(arr);
Console.WriteLine($"Чётных чисел в массиве = {sumEven[0]}");