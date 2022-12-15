Console.Write("Enter non-negative M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter non-negative N: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n < 0 || m < 0) Console.WriteLine("Enter correct numbers!");
int Accerman(int M, int N)
{
    if (M == 0 && N > -1) return N + 1;
    else if (M > 0 && N == 0) return Accerman(M - 1, 1);
    else if (M > 0 && N > 0) return Accerman(M - 1, Accerman(M, N - 1));
    else return 0;
}
int k = Accerman(m, n);
Console.Write(k);