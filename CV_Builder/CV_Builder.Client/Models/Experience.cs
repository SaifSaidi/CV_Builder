namespace CV_Builder.Client.Models
{
    
   public class Experience
    {
        public string Company { get; set; } = "";
        public string Position { get; set; } = "";
        public DateTime StartDate { get; set; } = DateTime.Today;
        public DateTime EndDate { get; set; } = DateTime.Today;
        public string Description { get; set; } = "";
        public override string ToString()
        {
            string dateRange = StartDate.ToString("MMMM yyyy") + " - " +
                               (EndDate == DateTime.Today ? "Present" : EndDate.ToString("MMMM yyyy"));

            return $"{Position} at {Company} ({dateRange})\nDescription: {Description}";
        }
    }


}
