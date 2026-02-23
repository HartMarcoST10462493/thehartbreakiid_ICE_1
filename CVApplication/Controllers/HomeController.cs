using Microsoft.AspNetCore.Mvc;
using CVApplication.Models;
using CVApplication.ViewModels;
using System.Collections.Generic;

namespace CVApplication.Controllers
{
    public class HomeController : Controller
    {
        // Add this method inside your HomeController class
        public IActionResult Contact()
        {
            ViewData["Message"] = "Get in touch for opportunities.";
            return View();
        }
        public IActionResult Index()
        {
            // 1. Unified Project List including your E-Commerce and Java projects
            var projects = new List<Project>
            {
                new Project
                {
                    Title = "Cloud E-Commerce Platform",
                    Description = "A full-stack e-commerce solution focused on cloud integration and scalable architecture.",
                    TechStack = "C#, ASP.NET, Azure",
                    GitHubUrl = "https://github.com/HartMarcoST10462493/CLDV6212_POE",
                    ImageUrl = "/images/ecommerce.jpg"
                },
                new Project
                {
                    Title = "Java Task Management System",
                    Description = "A comprehensive Java-based application developed to manage complex workflows and tasks.",
                    TechStack = "Java, Swing, Unit Testing",
                    GitHubUrl = "https://github.com/IIEMSA/prog5121-poe-part-3-thehartbreakiid",
                    ImageUrl = "/images/java-project.jpg"
                },
                new Project
                {
                    Title = "Azure Function App",
                    Description = "Developed a serverless backend for a Portfolio of Evidence (POE).",
                    TechStack = "C#, Azure, .NET",
                    GitHubUrl = "https://github.com/HartMarcoST10462493/CLDV6212_POE",
                    ImageUrl = "/images/azure-icon.png"
                },
                new Project
                {
                    Title = "Kotlin Task Manager",
                    Description = "An Android application built to streamline productivity.",
                    TechStack = "Kotlin, Android Studio, Firebase",
                    GitHubUrl = "https://github.com/your-repo",
                    ImageUrl = "/images/android-icon.png"
                }
            };

            // 2. Comprehensive Skills List - Marco Hart
            var skills = new List<Skill>
            {
                new Skill { Name = "C# / .NET", Category = "Languages" },
                new Skill { Name = "Java", Category = "Languages" },
                new Skill { Name = "Python", Category = "Languages" },
                new Skill { Name = "Kotlin", Category = "Languages" },
                new Skill { Name = "ASP.NET MVC", Category = "Frameworks" },
                new Skill { Name = "Azure", Category = "Tools" },
                new Skill { Name = "Git", Category = "Tools" },
                new Skill { Name = "AI/ML Engineering", Category = "Interests" }
            };

            // 3. Wrap in the ViewModel
            var viewModel = new PortfolioViewModel
            {
                Projects = projects,
                Skills = skills
            };

            return View(viewModel);
        }
    }
}