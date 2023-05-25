//задача 34
// Задайте массив, заполненный  случайными положительными трехзначными числами. Напишите программу,
// которая покажет количество четных чисел в массиве
// [345, 897, 568, 234] -> 2


/*int [] CreatRandomArray (int size, int minVal, int maxVal) 
{
    int [] newArray = new int [size]; 
    for (int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minVal, maxVal + 1);
    return newArray;
}

void ShowArray (int [] array1)
{
    for (int i = 0; i < array1.Length; i++)
        Console.Write(array1[i] + " ");
}

int FindEvenNumbers (int [] array)
{  
    int count = 0;
    for (int i = 0; i < array.Length; i = i + 1)
    {
        if (array[i] % 2 == 0)
        count++;
    }
    Console.WriteLine($"The even number {count}");
    return count;
}
Console.WriteLine("Input size of array: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());
int minValue = 100;
int maxValue = 1000;

int [] createArray = CreatRandomArray(sizeArray, minValue, maxValue);
ShowArray(createArray);
FindEvenNumbers(createArray);
*/



//Задача 36
// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих
// нв нечетных позицыиях
// [3, 7, 23, 12] -> 19

/*int [] CreatRandomArray (int size, int minVal, int maxVal) 
{
    int [] newArray = new int [size]; 
    for (int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minVal, maxVal + 1);
    return newArray;
}

void ShowArray (int [] array1)
{
    for (int i = 0; i < array1.Length; i++)
        Console.Write(array1[i] + " ");
}

int FindSumUnevenPosition (int [] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i = i + 2)
    {
        sum = sum + array[i];
    }
    Console.WriteLine($" Sum of number is {sum}");
    return sum;

}

Console.WriteLine("Input size of array: );
int sizeArray = Convert.ToInt32(Console.ReadLine());
int minValue = 1;
int maxValue = 50;
int [] createArray = CreatRandomArray(sizeArray, minValue, maxValue);
ShowArray(createArray);
FindSumUnevenPosition(createArray);
*/

//Задача 38
// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементом массива

double [] CreatRandomArray (int size) 
{
    double [] newArray = new double [size]; 
    for (int i = 0; i < size; i++)
        newArray[i] = new Random().NextDouble();
    return newArray;
}

void ShowArray (double [] array1)
{
    for (int i = 0; i < array1.Length; i++)
        Console.Write(array1[i] + " ");
}
void MaxMinElements ( double [] array)
{
    double max = array[0];
    double min = array[0];
    double difference = max;
    for (int i = 0; i < array.Length; i++)
    {
        if (max > array[i])
        max = array[i];
        else min = array[i];
        if (min > array[i]) 
        min = array[i];
    }
    difference = difference - min;
    Console.WriteLine($" difference max and min is {difference}");
}
int sizeArray = 5;

double [] createArray = CreatRandomArray(sizeArray);
ShowArray(createArray);
MaxMinElements(createArray);




