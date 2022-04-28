//Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.

/*Console.WriteLine("Введите длину массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] Fibonacci = new int [length];
Fibonacci[0] = 0;
Fibonacci[1] = 1;
for (int i = 2; i < length; i++)
{
    Fibonacci[i] = Fibonacci[i-1] + Fibonacci[i-2];
}
WriteArray(Fibonacci);
 
 
 
void WriteArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " "); 
    }
    Console.WriteLine();
}*/




// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.


Console.WriteLine("Введите длину массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] Fibonacci = new int [length];


FillArray(Fibonacci);
WriteArray(Fibonacci);

int [] newArray = new int [length];

for (int i = 0; i < length; i++)
{
    newArray[i] = Fibonacci[i];
}
Console.Write("Копия массива: ");
WriteArray(newArray);



void FillArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9, 10);
    }
}


void WriteArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " "); 
    }
    Console.WriteLine();
}