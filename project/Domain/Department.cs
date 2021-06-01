using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Department
    {
        [Key]
        public int DeptNo { get; set; }
        [Required]
        public string DeptName { get; set; }
        [Required]
        public Location Location { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}