using System;
using System.Collections.Generic;

namespace Hogwarts.DATA.EF.Models
{
    public partial class ScheduledClass
    {
        public ScheduledClass()
        {
            Enrollments = new HashSet<Enrollment>();
        }

        public int ScheduledClassId { get; set; }
        public int CourseId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string InstructorName { get; set; }
        public string Location { get; set; }
        public int Scsid { get; set; }

        public virtual Course? Course { get; set; }
        public virtual ScheduledClassStatus? Scs { get; set; }
        public virtual ICollection<Enrollment>? Enrollments { get; set; }
    }
}
