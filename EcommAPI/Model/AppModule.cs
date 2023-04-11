namespace EcommAPI.Model
{
    public class AppModule
    {
        public int ModuleId { get; set; }
        public string ModuleName { get; set; }
        public string ModuleImg { get; set; }
        public string Status { get; set; }
        public List<SubModule> subModules { get; set; }
        public AppModule()
        {
            subModules = new List<SubModule>();
        }
    }
    public class SubModule
    {
        public SubModule(){}
        public int SubModuleId { get; set; }
        public int ModuleId { get; set; }
        public string SubModuleName { get; set; }
        public string SubModuleImg { get; set; }
        public string RouterLink { get; set; }
        public string Status { get; set; }
    }
}
