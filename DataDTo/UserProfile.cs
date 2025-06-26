using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobSearchDataLayer.DataDTO
{
    public class UserProfile
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProfileId { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string ResumeUrl { get; set; }
        public string Location { get; set; }
        public string EducationDetails { get; set; }
        public double ExperienceDetails { get; set; }
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; }
    }

}
