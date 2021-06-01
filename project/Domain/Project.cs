using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Project
    {
        [Key]
        public int ProjectNo { get; set; }
        [Required]
        public string ProjectName { get; set; }
        public decimal? Budget { get; set; }
        public virtual ICollection<Works_on> Works { get; set; }
    }
}