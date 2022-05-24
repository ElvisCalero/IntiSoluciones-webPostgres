using System;
using System.Collections.Generic;
using webPostgres.Domain.Entities;

namespace webPostgres.Pages.Orders
{
    public class OrderDTO
    {
        public int Id { get; set; }
        public int Customer_Id { get; set; }
        public DateTime Order_Date { get; set; }
        public List<OrderDetail> orderDetails { get; set; } = new();
    }
}
