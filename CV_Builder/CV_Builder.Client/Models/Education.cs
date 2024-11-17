namespace CV_Builder.Client.Models
{
    public class Education
    {
        public string Institution { get; set; } = "";
        public string Degree { get; set; } = "";
        public DateTime GraduationDate { get; set; } = DateTime.Today;
        public override string ToString()
        {
            return $"{Degree} from {Institution}, Graduated on {GraduationDate:MMMM yyyy}";
        }
    }


}
