namespace RK1WebSite.Data.Models
{
    public class Category
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Car> Cars { get; set; }
        public string ApiName { get; set; }
    }
}
