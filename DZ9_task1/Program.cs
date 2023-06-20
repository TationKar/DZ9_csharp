// Задача 66: Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
using System;
using static System.Console;
Clear();
Write("Введите целое число M: ");
int m = int.Parse(ReadLine()!);
Write("Введите целое число N: ");
int n = int.Parse(ReadLine()!);
int tempNum = m;
if (n < m)
{
    m = n; n = tempNum;
}
WriteLine(RecursionMN(m, n));
int RecursionMN(int m, int n)
{
    if (n < m)
        return 0;
    int res = m + RecursionMN(++m, n);
    return res;
}