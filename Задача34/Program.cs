//Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

int size = new Random().Next(1, 11);
int[] numbers = new int[size];
FullArray(numbers);
PrintArray(numbers);

int countEven = 0;

foreach (int i in numbers)
    if (i % 2 == 0)
        countEven++;

Console.WriteLine($"\nКоличество четных чисел = {countEven}");

void FullArray(int[] array)
{
    for(int i=0; i < array.Length; i++)
        array[i] = new Random().Next(100, 1000);
}

void PrintArray(int[] array)
{
    for(int i=0; i < array.Length; i++)
        Console.Write(array[i] + " ");
}