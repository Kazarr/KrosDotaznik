namespace Data.Models.Registers
{
    public class WorkExpiration
    {
        public int Id { get; set; }
        /// <summary>
        /// Unlimited, or will expire
        /// </summary>
        public string JobExpire { get; set; }
    }
}
