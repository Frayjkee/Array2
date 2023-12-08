using System;

class Program
{
    static void Main()
    {
        // Создаем генератор случайных чисел
        Random random = new Random();

        // Задаем размер массива
        int arraySize = 10;

        // Создаем массив и заполняем его случайными числами
        int[] numbers = new int[arraySize];
        for (int i = 0; i < arraySize; i++)
        {
            numbers[i] = random.Next(1, 101); // Генерируем случайное число от 1 до 100
        }

        // Выводим массив на экран
        Console.WriteLine("Сгенерированный массив:");
        foreach (var number in numbers)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();

        // Определяем количество четных чисел в массиве
        int evenCount = CountEvenNumbers(numbers);

        // Выводим результат
        Console.WriteLine($"Количество четных чисел в массиве: {evenCount}");

        // Ждем, пока пользователь не нажмет Enter, чтобы консольное окно не закрылось
        Console.ReadLine();
    }

    // Метод для определения количества четных чисел в массиве
    static int CountEvenNumbers(int[] array)
    {
        int count = 0;
        foreach (var number in array)
        {
            if (number % 2 == 0)
            {
                count++;
            }
        }
        return count;
    }
}
