//Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

int size = new Random().Next(1, 16);
int[] numbers = new int[size];
FullArray(numbers);
PrintArray(numbers);

int sumNegativIndex = 0;

for (int i = 1; i < numbers.Length; i+=2)
    sumNegativIndex += numbers[i];

Console.WriteLine($"\nСумма элементов, стоящих на нечётных позициях = {sumNegativIndex}");

void FullArray(int[] array)
{
    for(int i=0; i < array.Length; i++)
        array[i] = new Random().Next(-10, 21);
}

void PrintArray(int[] array)
{
    for(int i=0; i < array.Length; i++)
        Console.Write(array[i] + " ");
}