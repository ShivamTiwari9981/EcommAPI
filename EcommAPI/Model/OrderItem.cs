namespace EcommAPI.Model
{
    public class OrderItem:BaseModel
    {
        public int OrderItemId { get; set; }
        public int OrderId { get; set; }
        public int MedicineId { get; set; }
        public Decimal UnitPrice { get; set; }
        public Decimal Discount { get; set; }
        public int Quantity { get; set; }
        public Decimal TotalPrice { get; set; }

    }
}
