namespace CVApplication.Models
{
    public class Project
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string TechStack { get; set; } = string.Empty;
        public string GitHubUrl { get; set; } = string.Empty;
        public string? DemoUrl { get; set; }
        public string ImageUrl { get; set; } = string.Empty;
    }
}