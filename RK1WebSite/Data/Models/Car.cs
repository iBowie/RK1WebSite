namespace RK1WebSite.Data.Models
{
    public class Car
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public ushort Price { get; set; } // why ushort
        public bool IsFavourite { get; set; } // why here
        public bool IsAvailable { get; set; }
        public int CategoryID { get; set; }

        public virtual Category Category { get; set; }
    }
}
