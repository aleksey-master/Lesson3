/* Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/

Console.Write("Введите число: ");
int cube = Convert.ToInt32(Console.ReadLine());

void Cube(int[] size)
{
    int i = 1;
    int length = size.Length;
    while (i < length)
    {
        size[i] = Convert.ToInt32(Math.Pow(i, 3));
        i++;
    }
}

void PrintArray(int[] array)
{
    int i = array.Length;
    for (int j = 1; j < array.Length; j++)
    {
        Console.Write(array[j] + " ");
    }
}

int[] array = new int[cube + 1];
Cube(array);
PrintArray(array);
