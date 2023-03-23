Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int sum = 0;

while (n != 0)
{
    int lastNum = n % 10;
    n = n / 10;
    sum = sum + lastNum;
}
Console.WriteLine($"{Math.Abs(sum)}");
 