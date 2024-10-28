using System;
namespace _09_DatabaseProject.Entities
{
	public class Order
	{
		public int Id { get; set; }
		public string OrderCustomer { get; set; }
        public byte ProductCount { get; set; }
        public decimal ProductUnitPrice { get; set; }
        public decimal TotalPrice { get; set; }
    }
}

