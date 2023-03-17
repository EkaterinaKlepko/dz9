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


// Console.WriteLine("Введите целое число");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите большее целое число");
// int n = Convert.ToInt32(Console.ReadLine());
// SummaRec(m, n);
// Console.WriteLine($"Сумма всех чисел от {m} до {n}: {SummaRec(n, m)}");

// int SummaRec(int m, int n)
// {   
//     if (m > n) return SummaRec(n, m);
//     if (n==m) return m;
//     return n + SummaRec(m, n - 1);
// }

// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

Console.WriteLine("Введите неотрицательное число");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите неотрицательное число");
int m = Convert.ToInt32(Console.ReadLine());
Akkerman(n, m);
Console.WriteLine(Akkerman(n, m));

int Akkerman(int n, int m)
{
    if (n == 0)
        return m + 1;
    else
      if ((n != 0) && (m == 0))
        return Akkerman(n - 1, 1);
    else
        return Akkerman(n - 1, Akkerman(n, m - 1));
}