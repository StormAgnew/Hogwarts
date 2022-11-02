using Hogwarts.DATA.EF.Metadata;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hogwarts.DATA.EF.Models
{
    [ModelMetadataType(typeof(StudentsMetadata))]
    public partial class Students
    {}

    [ModelMetadataType(typeof(EnrollmentsMetadata))]
    public partial class Enrollments
    {

    }

    [ModelMetadataType(typeof(StudentStatusesMetadata))]
    public partial class StudentStatuses
    {

    }

    [ModelMetadataType(typeof(ScheduledClassesMetadata))]
    public partial class ScheduledClasses
    {

    }
    [ModelMetadataType(typeof(CoursesMetadata))]
    public partial class Courses
    {

    }
}
