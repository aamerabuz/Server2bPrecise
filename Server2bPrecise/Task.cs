using System.ComponentModel.DataAnnotations;

namespace Server2bPrecise
{
    public class Task
    {
        public int Id { get; set; }
        [StringLength(200)]
        public string Text { get; set; } = string.Empty;
        public DateTime? DueDate { get; set; }
        public DateTime? TimeStamp { get; set; }
        public int EmployeeId { get; set; }
        public Employee? Employee { get; set; }

    }
}
