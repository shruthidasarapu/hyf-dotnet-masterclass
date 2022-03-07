// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
var time = new JupiterTime(2, 20);
var timeIn2Hours = time.AddHours(3);

PrintTime(timeIn2Hours);

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
    public int Hours
    {
        get
        {
            return _hours;
        }
        set
        {
            _hours = value;
        }
    }
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

    public JupiterTime AddHours(int number)
    {
        if (_hours + number > 12)
            _hours = _hours + number - 12;
        else if (_hours + number < 0)
            Console.WriteLine("Negative numbers are not accepted");
        else
            _hours = _hours + number;
        return this;
    }

}