// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
var time = new TitanTime(1000, 70);
PrintTime(time);


void PrintTime(TitanTime time)
{

    Console.WriteLine($"({time.Hours:000}:{time.Minutes:00})");
}
public class TitanTime
{
    private int _hours, _minutes;

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
    public TitanTime(int hours, int minutes)
    {

        Hours = hours % 900;
        Minutes = minutes % 60;
        if (minutes > 60)
        {
            Hours = Hours + minutes / 60;
        }

    }
}