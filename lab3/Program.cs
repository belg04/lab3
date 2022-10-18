// Лукьянов Глеб 22-ИСП-2\1 Уровень:Базовый Вариант: 2
using System.Globalization;

Console.Write("Ведите число А: ");
     int a = int.Parse(Console.ReadLine());
Console.Write("Ведите числа B: ");
     int b = int.Parse(Console.ReadLine());

for  (int i = b - 1; i > a; i--)
{
    Console.WriteLine(i);
    
}
int p=b - a - 1;
Console.WriteLine($"Количество чисел в промежутке {p}");  