/*
Задача 50. Напишите программу, которая на вход принимает позицию элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
5 -> 9
*/

Console.WriteLine("введите номер элемента");
int number=Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int [,] generateArray()
{   
    int m=new Random().Next(2,11);//число строк
    int n=new Random().Next(2,11);//число солбцов
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
void findNumberFromPosirion(int [,] array, int position)
{
    if (position<array.GetLength(0)*array.GetLength(1))
    {
        Console.WriteLine($"{number}->{array[number/array.GetLength(1),number%array.GetLength(1)]}");
    }
    else Console.WriteLine($"{number}->такого числа в массиве нет");
}
int [,] ourArray=generateArray();
printArray(ourArray);
findNumberFromPosirion(ourArray,number);