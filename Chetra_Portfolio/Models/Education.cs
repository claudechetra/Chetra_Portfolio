namespace Chetra_Portfolio.Models
{
    public class Education
    {
        public string Degree { get; set; }
        public string School { get; set; }
        public string Year { get; set; }
        public string SchoolLogo { get; set; }
        public List<Achievement> Achievements { get; set; }

        public class Achievement
        {
            public string Title { get; set; }
        }
    }


}
