namespace CloudAnalytic.Models
{
    public class AppConfig
    {
        public required string Version { get; set; }
        public bool Production { get; set; }
        public string? ConnectionString { get; set; }
    }
}