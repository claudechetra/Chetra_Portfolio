using System.Diagnostics;
using Chetra_Portfolio.Models;
using Microsoft.AspNetCore.Mvc;

namespace Chetra_Portfolio.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult About()
        {
            var model = new AboutMe
            {
                FullName = "Claude Chetra",
                Bio = "Passionate developer with experience in C#, ASP.NET, PHP, and Laravel.",
            };
            return View(model);
        }

        public IActionResult Skills()
        {
            var skills = new List<Skill>
        {
            new Skill { Name = "C#", Icon = "devicon-csharp-plain" },
            new Skill { Name = "ASP.NET", Icon = "devicon-dot-net-plain" },
            new Skill { Name = "PHP", Icon = "devicon-php-plain" },
            new Skill { Name = "Laravel", Icon = "devicon-laravel-plain" },
            new Skill { Name = "JavaScript", Icon = "devicon-javascript-plain" },
            new Skill { Name = "SQL", Icon = "devicon-mysql-plain" },
            new Skill { Name = "Git", Icon = "devicon-git-plain" },
            new Skill { Name = "HTML5", Icon = "devicon-html5-plain" },
            new Skill { Name = "CSS3", Icon = "devicon-css3-plain" }
        };

            return View(skills);
        }

        public IActionResult Education()
        {
            var education = new List<Education>
            {
                new Education
                {
                    School = "Royal University of Phnom Penh",
                    Year = "2017-2021",
                    SchoolLogo = "/images/school1.png",
                    Achievements = new List<Education.Achievement>
                    {
                        new Education.Achievement { Title = "Bachelor's degree of Computer Science" },
                    }
                },
                new Education
                {
                    School = "Australian Center for Education",
                    Year = "2014-2019",
                    SchoolLogo = "/images/school2.png",
                    Achievements = new List<Education.Achievement>
                    {
                        new Education.Achievement { Title = "General English Program" },
                        new Education.Achievement { Title = "Diploma in English Courses" }
                    }
                },
                new Education
                {
                    School = "Institut Français du Cambodge",
                    Year = "2022-2023",
                    SchoolLogo = "/images/school3.png",
                    Achievements = new List<Education.Achievement>
                    {
                        new Education.Achievement { Title = "Standard course" }
                    }
                }
            };

            return View(education);
        }



        public IActionResult Projects()
        {
            var projects = new List<Project>
            {
                new Project
                {
                    Title = "Neofi Solutions",
                    Company = "KHAWIN COMPANY LIMITED",
                    Duration = "2022 – Present",
                    Description = "Specializing in data integration (ETL), cash management, payment automation, compliance, fraud detection, BI dashboards, accounting reconciliation, eBAM, netting, and more. Built with ASP.NET"
                },
                new Project
                {
                    Title = "Accounting Management System",
                    Company = "KHAWIN COMPANY LIMITED",
                    Duration = "2020 – 2022",
                    Description = "An internal accounting system to manage invoicing, expenses, reports, and user roles. Implemented with PHP/Codeigniter and PostgreSQL."
                }          
            };

            return View(projects);
        }


        public IActionResult Contact()
        {
            var contact = new Contact
            {
                Phone = "+855 16 442 267",
                Email = "claudechetra46@gmail.com",
                Facebook = "https://www.facebook.com/chetra.claude.2025/",
                Instagram = "https://www.instagram.com/chetraaa___/",
                LinkedIn = "https://www.linkedin.com/in/claude-chetra-ab9826373/",
                GitHub = "https://github.com/claudechetra"
            };

            return View(contact);
        }
    }
}
