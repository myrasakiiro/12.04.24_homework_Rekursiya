// Задача 3: 

// Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

 void Main()
    {
        int[] array = { 1, 2, 3, 4, 5 }; // Задаем произвольный массив

        PrintArrayReversed(array, array.Length - 1); // Вызываем метод для печати массива, начиная с конца
    }

    void PrintArrayReversed(int[] array, int index)
    {
        if (index >= 0)
        {
            Console.Write(array[index] + " "); // Печатаем текущий элемент массива

            PrintArrayReversed(array, index - 1); // Рекурсивно вызываем метод для следующего элемента массива
        }
    }
    Main();