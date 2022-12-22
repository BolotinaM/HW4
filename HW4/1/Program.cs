// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B. Без модуля Math, используем цикл for.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int numberA = ReadInt("Число А:");
int numberB = ReadInt("Число В (степень числа А):");
ToDegree(numberA, numberB);

// Функции задачи №1
    // Функция для возведения числа в степень

    void ToDegree(int a, int b)
    {
        int resultD = 1;
        for (int i = 1; i <= b; i++)
        {
            resultD = resultD * a;
        }
        Console.WriteLine(resultD);
    }

    // Функция ввода данных

    int ReadInt(string message)
    {
        Console.WriteLine(message);
        return Convert.ToInt32(Console.ReadLine()); 
        // только я не понимаю, почему он ругается на  Convert.ToInt64
        // на Convert.ToInt16 тоже правильно работает
    }