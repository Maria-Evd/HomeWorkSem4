// Задача 25: Напишите цикл, который принимает на вход
// два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Console.WriteLine("Введите первое число: ");
// int A = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите второе число: ");
// int B = int.Parse(Console.ReadLine()!);

// int St(int A){ 
//     int C = Convert.ToInt32(Math.Pow(A, B));
// return C;
// }
// Console.WriteLine($"Число {A} в степени {B} равно {St(A)}");


// Задача 27: Напишите программу, которая принимает на 
// вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Console.WriteLine("Введите число: ");
// int A = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"Сумма цифр числа {A} равна {GetSum(A)}");

// int GetSum(int A){
//     int Sum = 0;
//     while (A > 0){
//         Sum = Sum + A % 10;
//         A = A / 10;
//      }
//     return Sum;
// }



// Задача 29: Напишите программу, которая задаёт 
// массив из 8 элементов и выводит их на экран. (можно указать любой промежуток)
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// int[] getArray(int size)
// {
//     int[] result = new int[size]; 
// for (int i = 0; i < size; i++)
// {
//     result[i] = new Random().Next(0, 100);
// }
// return result;
// }

// int[] array = getArray(8);
// Console.WriteLine($"[{String.Join(",",array)}]");
