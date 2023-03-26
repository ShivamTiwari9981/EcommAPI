namespace EcommAPI.Model
{
    public class CartModel:BaseModel
    {
        public int CartId { get; set; }
        public int UserId { get; set; }
        public int MedicineId { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Discount { get; set; }
        public int Quantity { get; set; }
        public string? TotalPrice { get; set; }
    }
}
