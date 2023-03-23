Console.Clear();
Console.Write("[");
int[] array = new int[8];
for (int i = 0; i < 8; i = i + 1)
{
    array[i] = new Random().Next(1,99);
    Console.Write(array[i] + ", ");
}
Console.Write("]");
