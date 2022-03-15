// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
var time2 = new JupiterTime(17, 88);
PrintTime(time2);

void PrintTime(JupiterTime time)
{
    Console.WriteLine($"({time.Hours:00}:{time.Minutes:00})");
}
public class JupiterTime
{
    public int Hours { get; set; }
    public int Minutes { get; set; }
    public JupiterTime(int hours, int minutes)
    {
        Hours = hours % 12;
        Minutes = minutes % 60;
        if (minutes > 60)
        {
            Hours = Hours + minutes / 60;
        }
    }

}
