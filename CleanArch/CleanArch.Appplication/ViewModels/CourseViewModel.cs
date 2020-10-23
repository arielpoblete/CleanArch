using CleanArch.Domain.Models;
using System.Collections.Generic;

namespace CleanArch.Appplication.ViewModels
{
    public class CourseViewModel
    {
        public IEnumerable<Course> Courses { get; set; }
    }
}
