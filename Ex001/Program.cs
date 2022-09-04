// Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
Console.Clear();
Console.WriteLine("Введи А");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Введи B");
int B = int.Parse(Console.ReadLine());
int stepen = 1;
for(int i = 0; i < B;i++) 
{
    stepen = stepen * A;
}
Console.WriteLine($"Степень А = {stepen}");