namespace CV_Builder.Client.Models
{
    public class CV
    {
        public PersonalInfo PersonalInfo { get; set; } = new PersonalInfo();
        public string Summary { get; set; } = "";
        public List<Experience> Experiences { get; set; } = new List<Experience>();
        public List<Education> Education { get; set; } = new List<Education>();
        public List<string> Skills { get; set; } = new List<string>();
        public List<Project> Projects { get; set; } = new List<Project>();
    }
}
