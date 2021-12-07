// See https://aka.ms/new-console-template for more information


Plane plane1 = new Plane();
plane1.Model = "Ryanair Abc123 ";

//V1
//plane1.speedEvent += Plane1_speedEvent;

//V2 
plane1.speedEvent += (speed) =>
{
    Console.WriteLine($"V2---Speed is reach {speed}");
};



for (int i = 100; i < 1000; i += 50)
{
    Thread.Sleep(200);
    plane1.Speed = i;
    Console.WriteLine($"{plane1.Model} speed is {i}");
}

//V1
//static void Plane1_speedEvent(int speed)
//{
//    Console.WriteLine($"V1---Speed is reach {speed}");
//}




public class Plane
{
    private int _speed;
    //public event speedDelegate speedEvent; //V1
    public event Action<int> speedEvent; //V2
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



//public delegate void speedDelegate(int speed); //V1 it is required by V1