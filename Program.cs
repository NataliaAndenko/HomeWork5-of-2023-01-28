/*Задача 2: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/
int[] GenerateArray(int len = 5)// функция генерации массива из 10 элементов
{
    int[] array = new int[len];
    Random rnd = new Random();//рандомные элементы массива
    for (int i = 0; i < array.Length; i++)//продолжаем массив циклом
    {
        array[i] = rnd.Next(0, 10);// размер массива от 0 до 9
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

int SumSign(int[] array)
{
    int sign = 1;
    if (sign % 2 == 1)
    {
        sign = 1;
    }
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        if ((array[i] + sign) > 0)
        {
            sum = sum + array[i];
        }
    }

    return sum;
}

int[] array = GenerateArray();
PrintArray(array);
System.Console.WriteLine($"Сума элементов, стоящих на нечетных позициях равна: {SumSign(array)}");