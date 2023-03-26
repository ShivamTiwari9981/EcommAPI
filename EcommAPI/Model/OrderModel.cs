namespace EcommAPI.Model
{
    public class OrderModel:BaseModel
    {
        public int OrderId { get; set; }
        public int UserId { get; set; }
        public string? OrderNo { get; set; }
        public int OrderTotal { get; set; }
        public string? OrderStatus { get; set; }
    }
}
