/*Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/

/* - решение - */

Console.Clear();
// Генератор случайных чисел 
int[] GetArrayRand(int size, int minVal, int maxVal)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minVal, maxVal + 1);
    }
    return res;
};

// Вывод массива в консоль 
void PrintArry(int[] coll)
{
    int count = coll.Length;
    int index = 0;
    Console.Write("[");
    while (index < count)
    {
        Console.Write(coll[index]);
        index++;
        if (index < count)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
};

//Подсчёт количества чётных чисел в массиве
int CalkEvenNumbers(int[] arr)
{
    int summEven = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            summEven++;
        };
    };
    return summEven;
};

//int[] array = new int[] { 345, 897, 568, 234 };
int[] array = GetArrayRand(4, 100, 999);

Console.WriteLine($"Количество чётных чисел {CalkEvenNumbers(array)}, в массиве :");
PrintArry(array);

/*--------------------------------------------------------------------------------------*/

/*Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

/* - решение - */

//Console.Clear();

// Калькулятор суммы элементов, стоящих на нечётных позициях.
int CalkSummOddIndex(int[] arr)
{
    int summ = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 != 0)
        {
            summ += arr[i];
        };
    };
    return summ;
};

//int[] array1 = new int[] { 3, 7, 23, 12 };
int[] array1 = GetArrayRand(4, -999, 999);

Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях = {CalkSummOddIndex(array1)}, в массиве :");
PrintArry(array1);

/*--------------------------------------------------------------------------------------*/

/*Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/

/* - решение - */

//Console.Clear();

//Калькулятор разницы между максимальным и минимальным элементом массива.
int CalkSummDifference(int[] arr)
{
    int max = arr[0];
    int min = arr[0];
    int res = 0;
    foreach (int i in arr)
    {
        if (max < i) max = i;
        if (min > i) min = i;
    };
    return res = max - min;
};

//int[] array2 = new int[] { 3, 7, 22, 2, 78 };
int[] array2 = GetArrayRand(4, -10, 999);

Console.WriteLine($"Разница между максимальным и минимальным элементом = {CalkSummDifference(array2)}, в массиве :");
PrintArry(array2);

/*
double[] arrayDouble = new double[] { -3, 7, 22, 2, 78, -3.5 };
//Калькулятор разницы между максимальным и минимальным элементом массива. Для вещественных чисел, которые обладают дробной частью.
double CalkSummDifferenceDouble(double[] arr)
{
    double max = arr[0];
    double min = arr[0];
    double res = 0;
    foreach (int i in arr)
    {
        if (max < i) max = i;
        if (min > i) min = i;
    };
    return res = max - min;
};
Console.WriteLine($"Разница между максимальным и минимальным элементом с дробной частью = {CalkSummDifferenceDouble}, в массиве :");
*/
