// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int lenArray = 8;

int[] randomArray = new int[lenArray];
for (int i = 0; i < randomArray.Length; i++)
{
    randomArray[i] = new Random().Next(1,100);
    Console.Write(randomArray[i] + " ");
}

// Так как в условии не сказано, кто вводит значения массива,
// я использовала заполнение псевдослучайными числами от 1 до 100