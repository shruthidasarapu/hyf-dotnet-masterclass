// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var time = new JupiterTime();
time.Hours = 8;
time.Minutes = 20;
PrintTime(time);

void PrintTime(JupiterTime time)
{
    Console.WriteLine($"({time.Hours:00}:{time.Minutes:00})");
}
public class JupiterTime
{
    public int Hours { get; set; }
    public int Minutes { get; set; }

}

