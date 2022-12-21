// Д.з.1 Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// Создание без массива.
// Цикл. Не надо сохранять

int[] CreateArray(int size)
{   
    int[]array = new int [size];

     for(int i=0; i<size; i++)
        
        {
            Console.Write("Введите число");
            int num = Convert.ToInt32(Console.ReadLine());
            array [i]= num;
        }
        return array;
}
   
void ShowArray(int[] array)
{
    for (int i=0; i<array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

Console.Write("Введите количество элементов в массиве:");
int size = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateArray(size);
ShowArray(myArray);

int kol (int[] array)
{
int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
         count++;
    }
    return count;
}

int result= kol (myArray);

Console.WriteLine ( $"Количество чётных чисел {result}");
