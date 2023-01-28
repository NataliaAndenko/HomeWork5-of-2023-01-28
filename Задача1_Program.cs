/*Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/
int[] GenerateArray(int len = 10)// функция генерации массива из 10 элементов
{
    int[] array = new int[len];
    Random rnd = new Random();//рандомные элементы массива
    for (int i = 0; i < array.Length; i++)//продолжаем массив циклом
    {
        array[i] = rnd.Next(100, 1000);// размер массива от 100 до 999
    }
    return array;//возвращаем массив
}

void PrintArray(int[] array)
{
    foreach (int item in array)
    {
        System.Console.Write($"{item}\t");
    }
    System.Console.WriteLine();
}

int Number(int[] array)
{
    int cnt = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            cnt++;
    }
    return cnt;
}

int[] array = GenerateArray();
PrintArray(array);
System.Console.WriteLine($"Четных чисел в массиве: {Number(array)}");
