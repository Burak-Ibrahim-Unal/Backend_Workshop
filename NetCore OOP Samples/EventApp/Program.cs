// See https://aka.ms/new-console-template for more information


Plane plane1 = new Plane();
plane1.Model = "Ryanair Abc123 ";
plane1.speedEvent += Plane1_speedEvent;



for (int i = 100; i < 1000; i += 50)
{
    Thread.Sleep(200);
    plane1.Speed = i;
    Console.WriteLine($"Plane speed is {i}");
}


static void Plane1_speedEvent(int speed)
{
    Console.WriteLine($"Plane speed is reach {speed}");
}




public class Plane
{
    private int _speed;
    public event speedDelegate speedEvent;
    public int Id { get; set; }
    public string Model { get; set; }
    public int Speed
    {
        get => _speed;
        set
        {
            if (value >= 500 && speedEvent != null)
            {
                speedEvent(value);
            }
            else
            {
                _speed = value;
            }
        }
    }
}



public delegate void speedDelegate(int speed);