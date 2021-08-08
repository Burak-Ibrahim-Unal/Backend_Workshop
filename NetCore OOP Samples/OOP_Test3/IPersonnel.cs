namespace OOP_Test3
{
    public interface IPersonnel
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public string Department { get; set; }

        public void Info();

    }
}