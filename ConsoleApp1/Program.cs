double[] numbers = { 1.0, 2.0, 3.0, 4.0, 5.0 };
double result = average(numbers);
Console.WriteLine(result);

int[] numbers2 = { 1, 2, 3, 4, 25, 6, 7, 8, 9 };
Console.WriteLine(max(numbers2));


static double average(double[] numbers)
{
    double sum = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        sum += numbers[i];
    }
    return sum / numbers.Length;
}


static int max(int[] numbers)
{
    int max = numbers[0];
    for (int i = 0; i < numbers.Length; i++)
    {
        if(numbers[i] > max)
            max = numbers[i];
    }

    return max;
}