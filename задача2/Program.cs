//Задача 36: Задайте одномерный массив, заполненный случайными числами 
//длина массива 5 элементов). Найдите сумму элементов, 
//стоящих на нечётных индексах (индексы с нуля).

//[3, 7, 23, 12] -> 19

//[-4, -6, 89, 6] -> 0

//Решение:

Console.WriteLine("Введите размер массива: ");
int arraySize = Convert.ToInt32(Console.ReadLine());
int[] array = new int[arraySize];

for (int i = 0; i < array.Length; i++)
{
    int randomNumber = new Random().Next(0, 10);
    array[i] = randomNumber;
    Console.Write(array[i] + " ");
}
 int summ = array[1]+array[3];
 Console.WriteLine($"сумма элементов, стоящих на нечётных индексах равна  {summ}");