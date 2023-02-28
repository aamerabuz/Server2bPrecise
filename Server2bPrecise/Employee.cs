using System.ComponentModel.DataAnnotations;

namespace Server2bPrecise
{
    public class Employee
    {
        public int Id { get; set; }
        [StringLength(30)]
        public string First { get; set; } = string.Empty;
        [StringLength(30)]
        public string Last { get; set; } = string.Empty;
        public int Position { get; set; }
        public int ManagerId { get; set; } = -1;
    }

    enum PositionType
    {
        Manager = 1, Employee = 2
    }
}
