/*
Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
int [,] generateArray()
{   
    int m=new Random().Next(2,5);//число строк
    int n=new Random().Next(2,5);//число солбцов
    int [,] massive=new int [m,n];
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j <massive.GetLength(1); j++)
        {    
            massive[i,j]=new Random().Next(10,100);
        }
    }
    return massive;
}
void Color(string data)
{
Console.ForegroundColor=ConsoleColor.Green;
Console.Write(data);
Console.ResetColor();
}
void printArray(int [,] array)
{
    Console.Write("\t");
    for (int i = 0; i < array.GetLength(1); i++)
        {       
            Color(i+"\t");
        }
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
            Color(i+"\t");
            for (int j = 0; j <array.GetLength(1); j++)
                {
                    array[i,j]=new Random().Next(10,100);
                    Console.Write(array[i,j] +"\t");
                }
            Console.WriteLine();
    }
}
void printAverage(int [,] array)
{       
    Color("avg"+"\t");
    
    for (int i = 0; i < array.GetLength(1); i++)
    {
        double sum=0;
        for (int j = 0; j <array.GetLength(0); j++)
            {
                sum+=array[j,i];
            }
        Color(Math.Round(sum/array.GetLength(0),2)+"\t");
    }
}

int [,] ourArray=generateArray();
printArray(ourArray);
printAverage(ourArray);
Console.WriteLine();

