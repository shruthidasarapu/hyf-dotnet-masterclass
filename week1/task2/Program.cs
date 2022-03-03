// See https://aka.ms/new-console-template for more information
string input = "Intellectualization";
char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };
int GetVowelCount(string text)
{
    return text.ToLower().Count(x => vowels.Contains(x));
}
int vowelCount = GetVowelCount(input); //TODO: Implement GetVowelCount 
Console.WriteLine($"Number of vowels: {vowelCount}");
