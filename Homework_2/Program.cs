/*Задача 2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/
int[] GenerateArray(int len = 10)// функция генерации массива
{
    int[] array = new int[len];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(1, 10);
    }
    return array;
}
int Summ(int[] array)  //сумму элементов, стоящих на нечётных позициях
{
    int summ = 0;
    for (int i = 0; i < array.Length; i = i + 2)//если на четных то От i=1
    {
        summ = summ + array[i];
    }
    return summ;
}
void PrintArray(int[] array) //пишет функцию (массив), написанный выше
{
    foreach (int item in array)//альтернатива циклу фор (работает не с индексами, а с элементами массива
    {
        System.Console.Write($"{item}\t");// выводит элемент массива
    }
    System.Console.WriteLine();//перевод курсора на след строку
}

Console.Clear();
int[] array = GenerateArray();
PrintArray(array);
System.Console.WriteLine($"сумма элементов, стоящих на нечётных позициях -> {Summ(array)}");