using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    public class Employee
    {
        [Key]
        public int EmpNo { get; set; }
        [Required]
        public string Fname { get; set; }
        [Required]
        public string Lname { get; set; }
        public decimal? Salary { get; set; }

        [ForeignKey("Department")]
        public virtual int DeptNo { get; set; }
        public virtual Department Department { get; set; }
        public virtual ICollection<Works_on> Works { get; set; }
    }
}
