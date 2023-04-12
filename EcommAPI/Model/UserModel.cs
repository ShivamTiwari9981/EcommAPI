namespace EcommAPI.Model
{                
    public class UserModel: BaseModel
    {
        public int UserId { get; set; }
        public int slNo { get; set; }
        public string FullName { get; set; }
        public string UserPassword { get; set; }
        public string Mobile { get; set; }
        public string Image { get; set; }
        public string Email { get; set; }
        public string Type { get; set; }
    }
}
