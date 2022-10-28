// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа 
// в промежутке от 1 до N.


// Console.WriteLine("Введите число N:");
// int n = Convert.ToInt32(Console.ReadLine());
// int a = 0;
// FindNatural();
// void FindNatural()
// {
//     a++;
//     Console.WriteLine(a);
//     if (a >= n)

//     {
//         return;
//     }
//     FindNatural();
// }

// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа 
// в промежутке от 1 до N. 2 вариант 

// int number = 10;
// int counter = 0;
// Zadacha633(number, counter);

// void Zadacha633(int number, int counter)
// {
//     counter++;
//     Console.WriteLine(counter);
//     if (counter >= number)
//         return;
//     Zadacha633(number, counter);
// }

// 65. Задайте значения M и N. Напишите программу
//  которая выведет все натуральные числа в промежутке от M до N



// Console.WriteLine("Введите число N:");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число M:");
// int m = Convert.ToInt32(Console.ReadLine());
// FindNatural(n, m);
// void FindNatural(int n, int a = 1)
// {

//     Console.WriteLine(a);
//     a++;

//     if (a >= n)
//     {
//         return;
//     }
//     FindNatural(n, a);
// }

// Задача 67: Напишите программу,
// которая будет принимать на вход число и возвращать сумму его цифр.


// int SumNum(int num, int sum = 0)
// {
//     if (num == 0)
//     {
//         return sum;
//     }
//     sum = sum + num % 10;
//     num = num / 10;
//     return SumNum(num, sum);
// }



// void Zadacha67()
// {
//     Console.WriteLine("Введите число :");
//     int num = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine(SumNum(num));
// }
// Zadacha67();


// Задача 69: Напишите программу, которая на вход принимает два числа A и B,
//  и возводит число А в целую степень B с помощью рекурсии.


int a=5;
int b=4;
int result=1;
for (int i=0; i<b; i++)
{
    result *=a;
}
Console.WriteLine($"{a}^{b} = {result}");

Pow (a,b);

void Pow (int a, int b, int result=1)
{
    if (b==0)
    {
        Console.WriteLine($"{result}");
        return;
    }
    result *=a;
    b--;
    Pow(a,b, result);
}