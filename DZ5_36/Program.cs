// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


void FillArray(int[] array)

{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 10);
    }
}

void PrintArray(int[] array)

{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}, ");
    }
    Console.Write("]");
}

void TheSumOfNonEvenPositives(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
            count += array[i];

    }
    System.Console.Write($" -> {count} ");

}

Console.WriteLine($"Enter the size of the array: ");
int array = Convert.ToInt32(Console.ReadLine());
int[] RandomArray = new int[array];
FillArray(RandomArray);
System.Console.WriteLine();
PrintArray(RandomArray);
TheSumOfNonEvenPositives(RandomArray);


