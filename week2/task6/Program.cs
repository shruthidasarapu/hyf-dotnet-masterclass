// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
var signaler = new Signaler();
signaler.AddTime(new JupiterTime(1, 20));
signaler.AddTime(new JupiterTime(2, 20));
signaler.AddTime(new JupiterTime(3, 20));
signaler.Inform();
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

public class Signaler
{
    List<JupiterTime> SignalerTime = new List<JupiterTime>();
    public void AddTime(JupiterTime time)
    {
        SignalerTime.Add(time);
    }
    public void Inform()
    {
        if (SignalerTime.Count == 0)
        {
            Console.WriteLine("No timers added yet");
        }
        else
        {
            foreach (var time in SignalerTime)
            {
                Console.WriteLine($"({time.Hours:00}:{time.Minutes:00})");
            }
        }
    }
}