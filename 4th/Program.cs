Console.Write("Enter number: ");
int num = Convert.ToInt32(Console.ReadLine());

 int Sum(int N)
{
    if (N % 10 == 0) return N;
    return (N % 10) + Sum(N / 10);
}

Console.Write(Sum(num));