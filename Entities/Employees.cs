using System.ComponentModel.DataAnnotations;

namespace Views_And_Procedures_STEP.Entities
{
    public class Employees
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public int Salary { get; set; }

        [Required]
        public int DepartmentId { get; set; }
        public bool IsActive { get; set; } = true;
        public Department Department { get; set; }
    }
}
