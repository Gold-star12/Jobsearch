using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearchDatabase.Data
{
    public class CandidateSkill
    {
        public int JobSeekerId { get; set; }
        public int SkillId { get; set; }
        public string SkillLevel { get; set; } // "Beginner", "Intermediate", "Expert"
        public bool IsPrimary { get; set; }

        public virtual JobSeeker JobSeeker { get; set; }
        public virtual Skill Skill { get; set; }
    }
}
