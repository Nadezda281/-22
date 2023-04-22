//Задача 38: Задайте массив вещественных чисел от -100 до 100 (длина массива 5 элементов). 
//Найдите разницу между максимальным и минимальным элементов массива.

//[3 7 22 2 78] -> 76
//Решение:

Console.WriteLine("Введите размер массива: ");
int arraySize = Convert.ToInt32(Console.ReadLine());
int[] array = new int[arraySize];

for (int i = 0; i < array.Length; i++)
{
    int randomNumber = new Random().Next(-100, 100);
    array[i] = randomNumber;
    Console.Write(array[i] + " ");
}
int max = array[0];
int min = array[0];

for (int i = 0; i < array.Length; i++)
{
    if (array[0] > max) max = array[0];
    {
        if (array[0] > max) max = array[0];
        if (array[1] > max) max = array[1];
        if (array[2] > max) max = array[2];
        if (array[3] > max) max = array[3];
        if (array[4] > max) max = array[4];
        
    }



    if (array[0] < min) min = array[0];
    {
        if (array[0] < min) min = array[0];
        if (array[1] < min) min = array[1];
        if (array[2] < min) min = array[2];
        if (array[3] < min) min = array[3];
        if (array[4] < min) min = array[4];
       
    }

}
int razn=max-min;

Console.WriteLine($"разницу между максимальным и минимальным элементов массива {razn}");