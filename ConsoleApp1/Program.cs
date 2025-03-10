double[] numbers = { 1.0, 2.0, 3.0, 4.0, 5.0 };
double result = average(numbers);
Console.WriteLine(result);


static double average(double[] numbers)
{
    double sum = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        sum += numbers[i];
    }
    return sum / numbers.Length;
}