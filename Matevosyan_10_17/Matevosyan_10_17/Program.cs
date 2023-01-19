float c = (2 * Fact(5) + 3 * Fact(8)) / (Fact(6) + Fact(4));
Console.WriteLine(c);

static int Fact(int n)
{
    int i, f = 1; 
    for (i = 1; i <= n; i++)
    {
        f *= i;
    }
    return f;
}
