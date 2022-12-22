// Д.з.1 Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// int[] CreateArray(int size)
// {   
//     int[]array = new int [size];

//      for(int i=0; i<size; i++)
        
//         {
//             Console.Write("Введите число:");
//             int num = Convert.ToInt32(Console.ReadLine());
//             array [i]= num;
//         }
//         return array;
// }
   
// int kol (int[] array)
// {
// int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > 0) count++;
//     }
//     return count;
// }


// Console.Write("Введите количество чисел:");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] myArray = CreateArray(size);
// int result= kol (myArray);
// Console.WriteLine ( $"Количество чисел больше 0: {result}");

// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2
//  задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Console.Write("Введите k1: ");
// Double k1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите b1: ");
// Double b1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите k2: ");
// Double k2 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите b2: ");
// Double b2 = Convert.ToDouble(Console.ReadLine());
 
 
// Double x = -(b1 - b2) / (k1 - k2);
// Double y = k1 * x + b1;
 
// x = Math.Round(x, 3);
// y = Math.Round(y, 3);
 
// Console.WriteLine($"Пересечение в точке: ({x};{y})");