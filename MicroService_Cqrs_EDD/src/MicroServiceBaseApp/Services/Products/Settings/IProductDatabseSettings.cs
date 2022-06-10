namespace Products.Settings
{
    public interface IProductsDatabaseSettings
    {
        public string ConnectionStrings { get; set; }
        public string DatabaseName { get; set; }
        public string CollectionName { get; set; }
        
    
    }

}