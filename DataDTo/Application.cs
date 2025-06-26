using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobSearchDataLayer.DataDTO
{
    public class Application
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ApplicationId { get; set; }
        public DateTime AppliedDate { get; set; }
        public string Status { get; set; } 
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; }
        public int JobId { get; set; }
        [ForeignKey("JobId")]
        public Job Job { get; set; }
    }

}
