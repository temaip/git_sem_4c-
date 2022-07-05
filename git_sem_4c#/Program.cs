
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.


// Console.WriteLine("Ввод числа A");
// int A = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Ввод числа B");
// int B = Convert.ToInt32(Console.ReadLine());
// int i = Convert.ToInt32(Math.Pow(A, B));
// Console.WriteLine(A + "," + B + " -> " + i);


//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.


// Console.WriteLine("Ввод числа N");
// int N = Convert.ToInt32(Console.ReadLine());
// int sum = 0;
// int x = N;
// while (x > 0)
// {
//     sum = sum + ( x % 10);
//     x = x / 10;

// }
//  Console.WriteLine(N + "->" + sum);


// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.


// int[] CreateArray()
// {
//     Console.WriteLine("Введите количество элементов массива");
//     int size = Convert.ToInt32(Console.ReadLine());
//     int[] RandomArray = new int[size];
//     for (int i = 0; i < size; i++)
//     {   
//         Console.WriteLine($"Введите {i+1} элемент массива");
//         RandomArray[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return RandomArray;
// }

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write( array[i] + " ");
//     }
//     Console.WriteLine();
// }
// Console.Clear();

// int[] myArray = CreateArray();
// ShowArray(myArray);