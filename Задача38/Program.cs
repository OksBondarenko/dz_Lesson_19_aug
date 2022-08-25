//Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементами массива.

int size = new Random().Next(1, 6);
double[] numbers = new double[size];
FullArray(numbers);
PrintArray(numbers);
double minNumber = numbers[0];
double maxNumber = numbers[0];
double difference = 0;

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] < minNumber)
        minNumber = numbers[i];
    else if(numbers[i] > maxNumber)
        maxNumber = numbers[i];
}

difference = maxNumber - minNumber;
Console.WriteLine($"\nРазница между максимальным и минимальным элементами массива = {difference}");

void FullArray(double[] array)
{
    for(int i=0; i < array.Length; i++)
        array[i] = new Random().Next(1, 21);
}

void PrintArray(double[] array)
{
    for(int i=0; i < array.Length; i++)
        Console.Write(array[i] + " ");
}