using System;

namespace webPostgres.Domain.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public int Customer_Id { get; set; }
        public DateTime Order_Date { get; set; }
    }
}
