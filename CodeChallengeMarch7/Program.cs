
long [] sum = { 0, 1,0};
long sumofEven = 0;

for (int i = 0; sum[2] < 4000000; i++)
{
    sum[2] = sum[0]+ sum[1];
    Console.WriteLine(sum[2]);
    if (sum[2] % 2 == 0)
    {
        sumofEven = sumofEven + sum[2];
    }
    sum[0] = sum[1];
    sum[1] = sum[2];
}
Console.WriteLine("Sum of even number is "+sumofEven);



