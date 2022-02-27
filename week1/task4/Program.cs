// See https://aka.ms/new-console-template for more information
int n = 6;
int Fibonacci(int n)
{
    if ((n == 0) || (n == 1))
    {
        return n;
    }
    else
        return Fibonacci(n - 1) + Fibonacci(n - 2);
}
int nthNumber = Fibonacci(n); //TODO: Implement Fibonacci
Console.WriteLine($"Nth fibonacci number is {nthNumber}");