static int WriteSumNums(int num1, int num2)
{
    if (num1 == num2) return num2;
    else return num1 + WriteSumNums(num1 + 1, num2);
}

Console.Write("Введите число M: ");
int numM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int numN = Convert.ToInt32(Console.ReadLine());

Console.Write(WriteSumNums(num1: numM, num2: numN));
