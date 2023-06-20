// Задача 68: Напишите программу вычисления функции 
//Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
using System;
using static System.Console;
Clear();
Write("Введите целое (не более 3-4) число M: ");
int m = int.Parse(ReadLine()!);
Write("Введите целое (не более 5) число N: ");
int n = int.Parse(ReadLine()!);
WriteLine($"A({n},{m}) = {RecursionMN(m, n)}");
int RecursionMN(int n, int m)
{
    while (n != 0)
    {
        if (m == 0)
            m = 1;
        else
            m = RecursionMN(n, m - 1);
        n = n - 1;
    }
    return m + 1;
}