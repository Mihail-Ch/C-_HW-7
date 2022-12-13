/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

double[,] randomNumber = new double[3, 4];
void PrintArray(double[,] random)
{
    for (int i = 0; i < randomNumber.GetLength(0); i++)
    {
        for (int j = 0; j < randomNumber.GetLength(1); j++)
        {
            Console.Write($"{randomNumber[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(double[,] randomNum) {
    for (int i = 0; i < randomNum.GetLength(0); i++)
    {
        for (int j = 0; j < randomNum.GetLength(1); j++)
        {
            randomNum[i,j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
}

FillArray(randomNumber);
PrintArray(randomNumber);

/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/


Console.WriteLine("введите номер строки");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите номер столбца");
int m = Convert.ToInt32(Console.ReadLine());
int [,] numbers = new int [10,10];
FillArrayRandomNumbers(numbers);

if (n > numbers.GetLength(0) || m > numbers.GetLength(1))
{
    Console.WriteLine("такого элемента нет");
}
else
{
    Console.WriteLine($"значение элемента {n} строки и {m} столбца равно {numbers[n-1,m-1]}");
}

PrintNewArray(numbers);

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {        
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array [i,j] = new Random().Next(-100, 100)/10;
            }   
        }
}

void PrintNewArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }   
        Console.Write("]");
        Console.WriteLine(""); 
    }
}


/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

Console.WriteLine("введите количество строк");
int one = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int two = Convert.ToInt32(Console.ReadLine());

int[,] numbersArray = new int[one, two];
FillArrayRandomNum(numbersArray);


for (int j = 0; j < numbersArray.GetLength(1); j++)
{
    double avarage = 0;
    for (int i = 0; i < numbersArray.GetLength(0); i++)
    {
        avarage = (avarage + numbersArray[i, j]);
    }
    avarage = avarage / one;
    Console.Write(avarage + "; ");
}
Console.WriteLine();
PrintAnotherArray(numbersArray);



void FillArrayRandomNum(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintAnotherArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}