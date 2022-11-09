// Задача 1: Задайте массив заполненный случайными положительными трехзначными
//          числами. Напишите программу, которая покажет количество четных чисел в массиве.
/*
void FillArrayRandomNumbers(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100, 1000);
    }
}

void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write(" ] ");
}
Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Ваш массив: ");
PrintArray(numbers);

int count = 0;

for (int i = 0; i < numbers.Length; i++)
if (numbers[i] % 2 == 0)
count++;
Console.WriteLine($"Четных чисел в массиве: " + count);
*/

// Задача 2: Задайте одномерный массив, заполненный случайными числами.
//           Найдите сумму элементов, стоящих на нечетных позициях.
/*
Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Наш массив");
PrintArray(numbers);

int sum = 0;
for(int i = 0; i < numbers.Length; i+=2)
    sum = sum + numbers[i];

    Console.WriteLine($"Всего {numbers.Length} чисел, сумма элементов на нечетных позициях = {sum}");

void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        numbers[i] = new Random().Next(1,10);
}    

void PrintArray(int[] numbers)
{
    Console.Write("[");
    for(int i = 0; i < numbers.Length; i++)
        Console.Write(numbers[i] + " ");

    Console.Write("]");
    Console.WriteLine();    
}
*/
// Задача 3. Задайте массив вещественных чисел. Найдите разницу между
//           максимальным и минимальным элементом массива.
/*
Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Ваш массив");
PrintArray(numbers);

double min = Int32.MaxValue;
double max = Int32.MinValue;

for(int i = 0; i < numbers.Length; i++)
{
    if(numbers[i] > max)
    {
        max = numbers[i];
    }
    if(numbers[i] < min)
    {
        min = numbers[i];
    }
}

Console.WriteLine($"Всего {numbers.Length} чисел. Макс значение = {max} ; мин значение = {min}");
Console.WriteLine($"Разница между макс и мин значением = {max - min}");

void FillArrayRandomNumbers(double[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = Convert.ToDouble(new Random().Next(100, 1000)) / 100;
    }
}

void PrintArray(double[] numbers)
{
    Console.Write(" [ ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }

    Console.Write("]");
    Console.WriteLine();
}
*/