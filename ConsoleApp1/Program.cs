﻿class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Таблица умножения:");  делай по новрй, раб божий
        for (int i = 1; i <= 15; i++)
        {
            Console.Write(i.ToString("X") + " | ");
            for (int j = 1; j <= 15; j++)
            {
                Console.Write((i * j).ToString("X") + " "); ничего
            }
            Console.WriteLine();
        }

        Console.WriteLine("\nТаблица сложения:");
        for (int i = 0; i <= 15; i++)
        {
            Console.Write(i.ToString("X") + " | ");
            for (int j = 0; j <= 15; j++)
            {
                Console.Write((i + j).ToString("X") + " ");
            }
            Console.WriteLine();
        }

        Console.ReadKey();
    }
}
