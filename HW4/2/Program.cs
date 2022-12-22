// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int number = ReadInt("");
int len = NumberLen(number);
SumNumbers(number, len);


// Фунции задачи № 2

    // Функция ввода данных: 6 строка
    int ReadInt(string message)
    {
        Console.Write(message);
        return Convert.ToInt32(Console.ReadLine());
    }

    // Функция оплеределения длины числа (символов): 7 строка
    int NumberLen(int a)
    {
        int i = 0;
        while (a > 0)
        {
            a /= 10;
            i++;
        }
        return i;
    }

    // Функция вывода суммы цифр в числе: 8 строка
    void SumNumbers(int n, int len)
    {
        int sum = 0;
        for (int j = 1; j <= len; j++)
        {
            sum += n % 10;
            n /= 10;
        }
        Console.WriteLine(sum);
    }