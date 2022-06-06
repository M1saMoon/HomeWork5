//Написать программу масштабирования фигуры
//Тут для тех кто далеко улетел, чтобы задавались вершины фигуры списком (одной строкой)
//например: "(0,0) (2,0) (2,2) (0,2)"
//коэффициент масштабирования k задавался отдельно - 2 или 4 или 0.5
//В результате показать координаты, которые получатся.
//при k = 2 получаем "(0,0) (4,0) (4,4) (0,4)"

Console.Clear();
void PrintArr(double[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}; ");
    }
}
double [] Scale (double [] array, double k)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] *= k;
    }
    return array;
}
double [] a = {0, 0};
double [] b = {2, 0};
double [] c = {2, 2};
double [] d = {0, 2};
Console.WriteLine("Введите коэффицент k" );
double k = double.Parse(Console.ReadLine() ??"0");
PrintArr(Scale(a,k));
PrintArr(Scale(b,k));
PrintArr(Scale(c,k));
PrintArr(Scale(d,k));