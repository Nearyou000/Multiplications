int MultOne(int a, int b)
{
    int result = 0;
    for(int i = a; i > 0; i--)
    {
        result += b;
    }
    return result;
}

int MultTwo(int a, int b)
{
    if (b == 0)
    {
        return 0;
    }
    return a + MultTwo(a, b - 1);
}

double MultThree(double a, double b)
{
    double result = 0;
    double log = Math.Log(a, 10.0) + Math.Log(b, 10.0);
    result = Math.Pow(10, log);
    return result;
}

double MultFour(double a, double b)
{
    return a / (1.0 / b);
}

int MultFive(int a, int b)
{
    int result = 0;
    while (a > 0)
    {
        if (a % 2 == 1)
        {
            result += b;
        }

        a /= 2;
        b *= 2;
    }
    
    return result;
}

Console.WriteLine(MultOne(10, 7));
Console.WriteLine(MultTwo(10, 7));
Console.WriteLine(MultThree(10, 7));
Console.WriteLine(MultFour(10, 7));
Console.WriteLine(MultFive(10, 7));