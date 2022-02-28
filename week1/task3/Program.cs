// See https://aka.ms/new-console-template for more information
int[] arr = new[] { 271, -3, 1, 14, -100, 13, 2, 1, -8, -59, -1852, 41, 5 };
int sumOfNegativeNumbers = 0;
int multipleOfPositiveNumbers = 1;
int[] GetResult(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < 0)
        {
            sumOfNegativeNumbers += arr[i];
        }
        else if (arr[i] >= 0)
        {
            multipleOfPositiveNumbers *= arr[i];
        }
    }
    return new int[] { sumOfNegativeNumbers, multipleOfPositiveNumbers };
}
int[] result = GetResult(arr); //TODO: Implement GetResult
Console.WriteLine($"Sum of negative numbers: {result[0]}. Multiplication of positive numbers: {result[1]}");