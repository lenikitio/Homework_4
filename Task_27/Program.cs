// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма цифр в числе {num} равна {GetSum(num)}");

int GetSum(int n)
{
    string StrN = Convert.ToString(n);
    int StrNLenght = StrN.Length;
    int Sum = 0;
    for(int i = 0; i < StrNLenght; i++)
    {
        String StrSN = Convert.ToString(StrN[i]);
        int IN = Convert.ToInt32(StrSN);
        Sum += IN;
    }
    return Sum;
}
