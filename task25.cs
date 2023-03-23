    Console.Clear();
    Console.Write("введите число A: ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.Write("введите число B: ");
    int pow = Convert.ToInt32(Console.ReadLine());
    int count = n;

    for (int i = 1; i < pow; i = i + 1)
    {
        count = count * n;
    }
    Console.WriteLine(count);
    