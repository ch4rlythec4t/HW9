static void WriteNums(int num1, int num2)
{
    if (num1 <= num2)
    {
        Console.Write(num1 + " ");
        num1++;
        WriteNums(num1, num2);
    }
}

Console.Write("Введите число M: ");
int numM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int numN = Convert.ToInt32(Console.ReadLine());

WriteNums(num1: numM, num2: numN);

