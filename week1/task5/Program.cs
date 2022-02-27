// See https://aka.ms/new-console-template for more information

int[] inputArray = new[] { 1, 2, 5, 7, 2, 3, 5, 7 };

if (inputArray.Length % 2 != 0)
{
    Console.WriteLine("can't split into two equal parts");
}
else
{

    int[][] Split(int[] inputArray)
    {
        int half = inputArray.Length / 2;
        int[] first = inputArray[..half];
        int[] second = inputArray[half..];
        int[][] twohalvarrays = new int[][] { first, second };
        return twohalvarrays;
    }
    int[][] splitArray = Split(inputArray);
    foreach (var item in splitArray)
    {
        Console.WriteLine(string.Join(",", item));
    }

    int[] AddArray(int[][] splitArray)
    {
        int length = splitArray[1].Length;
        Console.WriteLine($"{length}");
        int[] add = new int[length];
        for (int i = 0; i < length; i++)
        {
            add[i] = splitArray[0][i] + splitArray[1][i];
        }
        return add;
    }
    int[] result = AddArray(splitArray);

    void WriteResult(int[] result)
    {
        Console.WriteLine(string.Join(",", result));
    }
    WriteResult(result);
}





