// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
var time = new JupiterTime(2, 20);
Console.WriteLine(time);
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

    public override string ToString()
    {
        return "Time: " + _hours + ":" + _minutes;
    }

}
