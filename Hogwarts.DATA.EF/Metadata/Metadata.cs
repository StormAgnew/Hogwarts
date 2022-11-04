using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hogwarts.DATA.EF.Models
{
    #region Students Metadata
    public class StudentsMetadata
    {
        //PK
        public int StudentId { get; set; }

        [Required(ErrorMessage = "A First Name is required!")]
        [Display(Name = "First Name")]
        [StringLength(20)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "A Last Name is required!")]
        [Display(Name = "Last Name")]
        [StringLength(20)]
        public string LastName { get; set; }

        [Display(Name = "Name")]
        public string FullName { get { return $"{FirstName} {LastName}"; } }


        
        [StringLength(15)]
        public string Major { get; set; }

        [StringLength(50)]
        public string Address { get; set; }

        [StringLength(25)]
        public string City { get; set; }

        [StringLength(2)]
        public string State { get; set; }

        [StringLength(10)]
        public string ZipCode { get; set; }

        [StringLength(13)]
        public string Phone { get; set; }

        [StringLength(60)]
        [Required(ErrorMessage = "Each Student MUST have a functional Email!")]
        public string Email { get; set; }


        [StringLength(100)]
        public string PhotoUrl { get; set; }

        //FK
        public int SSID { get; set; }
    }
    #endregion

    #region Enrollments Metadata
    public class EnrollmentsMetadata
    {
        //PK
        public int EnrollmentId { get; set; }

        //FK
        public int StudentId { get; set; }

        //FK
        public int ScheduledClassId { get; set; }

        [DataType(DataType.Date)]
        public DateTime EnrollmentDate { get; set; }

    }
    #endregion

    #region StudentStatuses Metadata
    public class StudentStatusesMetadata
    {
        //PK
        public int SSID { get; set; }

        [StringLength(30)]
        public string SSName { get; set; }

        [StringLength(250)]
        public string SSDescription { get; set; }
    }
    #endregion

    #region ScheduledClasses Metadata
    public class ScheduledClassesMetadata
    {
        //PF
        public int ScheduledClassId { get; set; }

        //FK
        public int CourseId { get; set; }

        [DataType(DataType.Date)]
        [Required]
        public DateTime StartDate { get; set; }

        [DataType(DataType.Date)]
        [Required]
        public DateTime EndDate { get; set; }

        [StringLength(40)]
        [Required]
        public string InstructorName { get; set; }

        [StringLength(20)]
        [Required]
        public string Location { get; set; }


        //FK?
        public int SCSID { get; set; }

    }
    #endregion

    #region Courses Metadata
    public class CoursesMetadata
    {
        //PK
        public int CourseId { get; set; }

        [StringLength(50)]
        public string CourseName { get; set; }

        //In DB, says varchar(MAX)? Evan confirmed not to put a length
        public string CourseDescription { get; set; }

        public int CreditHours { get; set; }

        [StringLength(250)]
        public string Curriculum { get; set; }

        [StringLength(500)]
        public string Notes { get; set; }

        public bool IsActive { get; set; }  
    }
    #endregion

    #region ScheduledClassStatuses
    public class ScheduledClassStatusesMetadata
    {
        public int SCSID { get; set; }

        [StringLength(50)]
        [Required]
        public string SCSName { get; set; }
    }
    #endregion
}
