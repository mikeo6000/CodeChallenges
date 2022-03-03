

int f = 1;
string k = "";
int count;
int i = 2;

int divisors = 500;


    do
    {
    k = k + f.ToString() + " -> " + divisorsCount(f) + "\n";
    f = f + i;
    i++;
} while (count <= divisors);

Console.WriteLine(k);


 int divisorsCount(int num)
{
     count = 0;
    if (num == 1) return 1;
    int sqrtP = (Int32)(Math.Truncate(Math.Sqrt(num)));
    count = 2;
    for (int i = 2; i <= sqrtP; i++)
    {
        if (num % i == 0)
        {
            count = count + 2;       
        }
    }
    if (sqrtP * sqrtP == num)
    {
        count = count - 1;
    }
    return count;
}