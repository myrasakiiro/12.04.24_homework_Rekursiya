// Задача 2: 

// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

void Main()
    {
        int m = 2; // Задаем первый аргумент
        int n = 3; // Задаем второй аргумент

        int result = Ackermann(m, n); // Вычисляем значение функции Аккермана для заданных аргументов

        Console.WriteLine($"A({m}, {n}) = {result}"); // Выводим результат
    }

    int Ackermann(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (m > 0 && n == 0)
        {
            return Ackermann(m - 1, 1);
        }
        else 
        {
            return Ackermann(m - 1, Ackermann(m, n - 1));
        }
    }
Main();