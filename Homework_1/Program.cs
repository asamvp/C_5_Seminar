/*Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/
int[] GenerateArray(int len = 10)// функция генерации массива
{
    int[] array = new int[len];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(100, 1000);
    }
    return array;
}
int Number(int[] array)  //количество четных чисел массива
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            count++;
    }
    return count;
}
void PrintArray(int[] array) //пишет функцию (массив), написанный выше
{
    foreach (int item in array)//альтернатива циклу фор (работает не с индексами, а с элементами массива
    {
        System.Console.Write($"{item}\t");// выводит элемент массива
    }
    System.Console.WriteLine();//перевод курсора на след строку
}

int[] array = GenerateArray();
PrintArray(array);
System.Console.WriteLine($"количество четных чисел массива -> {Number(array)}");