// Напишите программу, которая задаёт массив из 8 элементов 
// и выводит их на экран.
Console.Clear();
Console.WriteLine("Введи количество элементов массива");
int count = int.Parse(Console.ReadLine());
int [] array = new int [count];
for (int i = 0; i < count; i++ ) 
{
    array [i] = int.Parse(Console.ReadLine());
    
}
for (int i = 0; i < count; i++ ) 
{
    Console.Write ($"{array[i]} ");
}