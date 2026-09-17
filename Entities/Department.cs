using System.ComponentModel.DataAnnotations;

namespace Views_And_Procedures_STEP.Entities
{
    public class Department
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        public ICollection<Employees> Employees { get; set; } = new List<Employees>();
    }
}
