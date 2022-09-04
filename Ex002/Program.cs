// Напишите программу, которая принимает на вход
// число и выдаёт сумму цифр в числе.
Console.Clear();
Console.WriteLine("Введи число");
int A = int.Parse(Console.ReadLine());
int sum_of_digits = 0;
int digit;
while(A > 0) 
{
    digit = A %10;
    sum_of_digits  = sum_of_digits + digit;
    A = A /10;
}
Console.WriteLine($"Сумма цифр = {sum_of_digits}");