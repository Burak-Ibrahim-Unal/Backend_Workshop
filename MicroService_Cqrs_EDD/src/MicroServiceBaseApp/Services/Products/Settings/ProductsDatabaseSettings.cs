namespace Products.Settings
{
    public class ProductsDatabaseSettings : IProductsDatabaseSettings
    {
        public string ConnectionStrings { get; set; }
        public string DatabaseName { get; set; }
        public string CollectionName { get; set; }
    }
}