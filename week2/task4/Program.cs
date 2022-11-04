// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
var time = new JupiterTime(2, 20);
var timeIn20Minutes = time.AddMinutes(30);

PrintTime(timeIn20Minutes);

void PrintTime(JupiterTime time)
{
    Console.WriteLine($"({time.Hours:00}:{time.Minutes:00})");
}
public class JupiterTime
{
    private int _hours, _minutes;
    public JupiterTime(int hours, int minutes)
    {
        Hours = hours;
        Minutes = minutes;
    }
    public int Hours { get; set; }
    public int Minutes
    {
        get
        {
            return _minutes;
        }
        set
        {
            _minutes = value;
        }
    }
    public JupiterTime AddMinutes(int number)
    {
        if (_minutes + number > 60)
            _minutes = (_minutes + number) % 60;
        else if (_minutes + number < 0)
            Console.WriteLine("Negative numbers are not accepted");
        else
            _minutes = _minutes + number;
        return new JupiterTime(_hours, _minutes);
    }

}