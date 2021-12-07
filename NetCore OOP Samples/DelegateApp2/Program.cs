// See https://aka.ms/new-console-template for more information

List<Worker> workers = new List<Worker>();
Worker worker1 = new Worker
{
    Id = 1,
    Name = "burak1",
    SurName = "unal1",
    Salary = 10000,
    Experience = 5,
    City = "Ankara"
};


Worker worker2 = new Worker
{
    Id = 2,
    Name = "burak2",
    SurName = "unal2",
    Salary = 20000,
    Experience = 3,
    City = "Istanbul"
};
Worker worker3 = new Worker
{
    Id = 3,
    Name = "burak3",
    SurName = "unal3",
    Salary = 30000,
    Experience = 4,
    City = "izmir"
};
Worker worker4 = new Worker
{
    Id = 4,
    Name = "burak4",
    SurName = "unal4",
    Salary = 40000,
    Experience = 2,
    City = "Ankara"
};
Worker worker5 = new Worker
{
    Id = 5,
    Name = "burak5",
    SurName = "unal5",
    Salary = 50000,
    Experience = 9,
    City = "izmir"
};

workers.Add(worker5); workers.Add(worker4); workers.Add(worker3); workers.Add(worker2); workers.Add(worker1);

//Best Way...

//Worker.Promotion(workers, w => w.Salary > 30000);
//Console.WriteLine("----------------------------------------------------------");
//Worker.Promotion(workers, w => w.Experience >= 4);
//Console.WriteLine("----------------------------------------------------------");
//Worker.Promotion(workers, w => w.City == "Ankara");

//Worker.Promotion(workers, new WorkerDelegate(GetPromotionWithExperience6));
Worker.PromotionV2(workers, GetPromotionWithExperience5);
Console.WriteLine("----------------------------------------------------------");
Worker.PromotionV3(workers, GetPromotionWithExperience5);


bool GetPromotionWithSalary30000(Worker worker)
{
    if (worker.Salary >= 30000)
    {
        return true;
    }
    else
    {
        return false;
    }
}

bool GetPromotionWithExperience5(Worker worker)
{
    if (worker.Experience >= 5)
    {
        return true;
    }
    else
    {
        return false;
    }

}


public class Worker
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string SurName { get; set; }
    public int Salary { get; set; }
    public int Experience { get; set; }
    public string City { get; set; }


    public static void Promotion(List<Worker> workers, WorkerDelegate workerDelegate)
    {
        foreach (var worker in workers)
        {
            if (workerDelegate(worker))
            {
                Console.WriteLine($"{worker.Name} {worker.SurName}");
            }
        }
    }

    public static void PromotionV2(List<Worker> workers, Func<Worker, bool> workerDelegate) // Net Framework 1. delegate...We dont need custom delegates...
    {
        foreach (var worker in workers)
        {
            if (workerDelegate(worker))
            {
                Console.WriteLine($"{worker.Name} {worker.SurName}");
            }
        }
    }

    public static void PromotionV3(List<Worker> workers, Predicate<Worker> workerDelegate) // Net Framework 2. delegate...We dont need custom delegates...
    {
        foreach (var worker in workers)
        {
            if (workerDelegate(worker))
            {
                Console.WriteLine($"{worker.Name} {worker.SurName}");
            }
        }
    }
}


public delegate bool WorkerDelegate(Worker worker); // it is required by  Promotion method...Not necessary for Promotion method