// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет 
// количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
}

void PrintArray(int[] array)
{
    int count = array.Length;
    int i = 0;
    while (i < count)

    {
        System.Console.Write($" {array[i]} ");
        i++;
    }
}
System.Console.WriteLine();

void EvenNumbers(int[] array)


{  
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
         if (array[i] % 2 == 0)
         count = count + 1;
         
    }   
    System.Console.WriteLine($" -> Even numbers in array = {count} ");

}


System.Console.WriteLine("Enter the size of the array: ");
int array = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine();
int[] RandomArray = new int[array];
FillArray(RandomArray);
PrintArray(RandomArray);
EvenNumbers(RandomArray);