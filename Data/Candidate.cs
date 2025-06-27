using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearchDatabase.Data
{
    public class Candidate
    {
        public int CandidateId { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public string FirstName { get; set; }
            public string LastName { get; set; }
            public DateOnly DateOfBirth { get; set; }
            public string Gender { get; set; }
            public string Address { get; set; }
            public string City { get; set; }
            public string State { get; set; }
            public string Country { get; set; }
            public string ZipCode { get; set; }
            public string ResumeFilePath { get; set; }
            public string ProfileSummary { get; set; }

            public virtual ICollection<Education> Educations { get; set; }
            public virtual ICollection<WorkExperience> WorkExperiences { get; set; }
            public virtual ICollection<JobSeekerSkill> Skills { get; set; }
            public virtual ICollection<JobApplication> Applications { get; set; }
        
    }
}
