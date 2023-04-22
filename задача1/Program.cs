//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами 
//(длина массива 5 элементов). Напишите программу, которая покажет количество чётных чисел
// в массиве.

//[345, 897, 568, 234] -> 2

//Решение:

Console.WriteLine("Введите размер массива: ");
int arraySize = Convert.ToInt32(Console.ReadLine());
int[] array = new int[arraySize];

for (int i = 0; i < array.Length; i++)
{
    int randomNumber = new Random().Next(100, 999);
    array[i] = randomNumber;
    Console.Write(array[i] + " ");
}
int chet = 0;
for (int i = 0; i < array.Length; i++)
{
    {
        if (array[i] % 2 == 0)
            chet = chet + 1;
    }
    if (array[i] % 2 != 0)
    {
        //Console.WriteLine($"");
        continue;
    }
}
Console.WriteLine($"количество четных чисел в массиве {chet}");