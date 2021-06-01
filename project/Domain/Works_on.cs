using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    public class Works_on
    {
        [ForeignKey("Project")]
        public int ProjectNo { get; set; }
        [ForeignKey("Employee")]
        public int EmpNo { get; set; }
        public virtual Project Project { get; set; }
        public virtual Employee Employee { get; set; }
        public string Job { get; set; }
        [DataType("date")]
        public DateTime Enter_Date { get; set; }

    }
}
