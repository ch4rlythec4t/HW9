static int AkkermanFunction(int num1, int num2)
{
    if (num1 == 0) return num2 + 1;
    else
        if ((num1 != 0) && (num2 == 0)) return AkkermanFunction(num1 - 1, 1);
        else return AkkermanFunction(num1 - 1, AkkermanFunction(num1, num2 - 1));
}

Console.Write("Введите число M: ");
int numM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int numN = Convert.ToInt32(Console.ReadLine());

Console.Write(AkkermanFunction(num1: numM, num2: numN));
