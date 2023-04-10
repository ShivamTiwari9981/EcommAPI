namespace EcommAPI.Model
{
    public class AppModule
    {
        public int module_id { get; set; }
        public string module_nam { get; set; }
        public string module_img { get; set; }
        public string status { get; set; }
        public List<SubModule> subModules { get; set; }
        public AppModule()
        {
            subModules = new List<SubModule>();
        }
    }
    public class SubModule
    {
        public SubModule(){}
        public int view_id { get; set; }
        public int module_id { get; set; }
        public string view_nam { get; set; }
        public string module_img { get; set; }
        public string actionLink { get; set; }
        public string status { get; set; }
    }
}
