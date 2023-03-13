// Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.


// Console.WriteLine("Введите целое число");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(Rec(n));


// string Rec(int n)
// {
//     if (n==0) return "";

//     return Convert.ToString(n) + " " + Rec(n-1);

// }


// Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.WriteLine("Введите целое число");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите большее целое число");
int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Сумма всех чисел от {m} до {n} равна {Summa(n, m)}");
Console.WriteLine($"Сумма всех чисел от {m} до {n} равна {SummaRec(n, m)}");


// int Summa(int n, int m)
// {
//     int sum = m + 1;
//     while (true)
//     {
//         if (m == n)
//             break;
//         sum = sum + 1;
//         m++;
//     }
//     return sum;
// }

int SummaRec(int n, int m)
{
    if (m==n) return 0;
    return m + SummaRec(n - 1, m);
    //SummaRec(5)
    //return 5 + ( 4 + (3 + ( 1 + 0)))
}