namespace Data.Models.Registers
{
    public class WorkHours
    {
        public int Id { get; set; }
        /// <summary>
        /// Fulltime, Parttime...
        /// </summary>
        public string NameOfHoursPerWeek { get; set; }
        /// <summary>
        /// If parttime then how many hours per week
        /// </summary>
        public int HoursPerWeek { get; set; }
    }
}
