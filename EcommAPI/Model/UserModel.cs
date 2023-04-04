namespace EcommAPI.Model
{                
    public class UserModel: BaseModel
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserPassword { get; set; }
        public string Email { get; set; }
        public string Type { get; set; }
    }
}
