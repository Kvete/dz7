/*
Задача 47. Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

Console.WriteLine("введите числот строк");
int m=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите числот столбцов");
int n=Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

void generationArray(int k, int s)
{
double [,] massive=new double [k,s];
Console.Write("\t");
for (int i = 0; i < massive.GetLength(1); i++)
{
    Color(i+"\t");
}

Console.WriteLine();

for (int i = 0; i < massive.GetLength(0); i++)
{
    Color(i+"\t");
    for (int j = 0; j <massive.GetLength(1); j++)
    {
        massive[i,j]=Math.Round(new Random().NextDouble()*100,2);
        Console.Write(massive[i,j] +"\t");
    } 
    Console.WriteLine();
}
}
void Color(string data)
{
Console.ForegroundColor=ConsoleColor.Green;
Console.Write(data);
Console.ResetColor();
}

generationArray(m,n);
