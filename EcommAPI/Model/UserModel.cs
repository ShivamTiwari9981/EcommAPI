namespace EcommAPI.Model
{                
    public class UserModel: BaseModel
    {
        public int UserId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Password { get; set; }
        public string? Email { get; set; }
        public decimal Fund { get; set; }
        public string? Type { get; set; }
    }
}
