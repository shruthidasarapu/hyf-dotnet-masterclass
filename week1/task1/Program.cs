// See https://aka.ms/new-console-template for more information
string inputString = "world";
string ReverseString(string input)
{
    char[] array = input.ToCharArray();
    Array.Reverse(array);
    return new string(array);
}
string reversed = ReverseString(inputString); //TODO: Implement ReverseString
Console.WriteLine($"Reversed input value: {reversed}");