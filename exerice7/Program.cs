Console.Write("Введите число N: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine($"Четные числа от 1 до {n}:");
        for (int i = 2; i <= n; i += 2)
        {
            Console.Write($"{i} ");
        }