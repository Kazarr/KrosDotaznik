namespace Data.Models.Registers
{
    public class WorkPosition
    {
        public int Id { get; set; }
        public string Position { get; set; }

        public WageCategory WageCategory { get; set; }
    }
}
