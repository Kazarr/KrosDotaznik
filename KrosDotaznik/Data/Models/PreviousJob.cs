using System;

namespace Data.Models
{
    public class PreviousJob
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; } = DateTime.Now;
        public DateTime EndDate { get; set; } = DateTime.Now;
        public string EmployerCompanyName { get; set; }
        public string Position { get; set; }
    }
}
