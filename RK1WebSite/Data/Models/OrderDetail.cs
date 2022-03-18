﻿namespace RK1WebSite.Data.Models
{
    public class OrderDetail
    {
        public int ID { get; set; }
        public int OrderID { get; set; }
        public int CarID { get; set; }
        public uint Price { get; set; }

        public virtual Car Car { get; set; }
        public virtual Order Order { get; set; }
    }
}
