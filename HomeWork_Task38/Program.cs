// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

Console.WriteLine($"Задайте массив из вещественных чисел: ");

double[] arrayRealNumbers = new double[5];
    for (int i = 0; i < arrayRealNumbers.Length; i++ )
    {
    arrayRealNumbers[i] = new Random().Next(1, 10);
    Console.Write(arrayRealNumbers[i] + " ");
    }

double maxNumber = arrayRealNumbers[0];
double minNumber = arrayRealNumbers[0];

    for (int i = 1; i < arrayRealNumbers.Length; i++)
    {
        if (maxNumber < arrayRealNumbers[i])
        {
        maxNumber = arrayRealNumbers[i];
        }
            if (minNumber > arrayRealNumbers[i])
            {
            minNumber = arrayRealNumbers[i];
        }
    }

double decision = maxNumber - minNumber;
Console.Write($"\nРазница между между максимальным ({maxNumber}) и минимальным ({minNumber}) элементами массива: {decision}");

