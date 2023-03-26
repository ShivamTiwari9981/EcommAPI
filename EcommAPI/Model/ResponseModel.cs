namespace EcommAPI.Model
{
    public class ResponseModel
    {
        public bool Status { get; set; }
        public string? Message { get; set; }
        public Object? data { get; set; }
    }
}
