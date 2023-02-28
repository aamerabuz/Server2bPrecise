using System.ComponentModel.DataAnnotations;

namespace Server2bPrecise
{
    public class Report
    {
        public int Id { get; set; }
        [StringLength(200)]
        public string Text { get; set; } = string.Empty;
        public DateTime? TimeStamp { get; set; }
        public int EmployeeId { get; set; }
        public Employee? Employee { get; set; }
    }
}
