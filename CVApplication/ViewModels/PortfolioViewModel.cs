using CVApplication.Models;
using System.Collections.Generic;

namespace CVApplication.ViewModels
{
    public class PortfolioViewModel
    {
        public List<Project> Projects { get; set; } = new List<Project>();
        public List<Skill> Skills { get; set; } = new List<Skill>();
    }
}