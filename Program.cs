int GetNumber(string message)
{
    int resalt = 0;
    while(true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out resalt))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число. Повторите ввод");
        }
    }
    return resalt;
}

int AkkermanFunction(int m, int n)
{
    if (m == 0) 
    {
    return n + 1;
    }
    else if (n == 0 && m> 0)
        {
        return AkkermanFunction(m - 1, 1);
        }
        else
        {
            return (AkkermanFunction(m - 1, AkkermanFunction(m, n-1)));
        }
 }
int m = GetNumber("Введите M -> ");
int n = GetNumber("Введите N -> ");
Console.WriteLine(AkkermanFunction(m, n));
