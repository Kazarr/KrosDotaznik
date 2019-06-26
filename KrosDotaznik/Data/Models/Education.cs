using Data.Models.Registers;

namespace Data.Models
{
    public class Education
    {
        public int Id { get; set; }
        public string School { get; set; }
        public string Major { get; set; }
        public int EndYear { get; set; }

        public EducationLevel EducationLevel { get; set; }
    }
}
