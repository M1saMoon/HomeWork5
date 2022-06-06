//Написать программу копирования массива

void CopyArr (int[] array)
{
    int [] Dolly = new int[array.Length];
    for(int i = 0; i < array.Length; i++)
    {
        Dolly[i] = array[i];
        Console.Write(Dolly[i] + " ");
    }
}
int [] array = new int [10];
for(int i = 0; i < 10; i++)
{
    array [i] = new Random().Next(1,100);
    Console.Write(array[i] + " ");
}
Console.WriteLine();
CopyArr(array);