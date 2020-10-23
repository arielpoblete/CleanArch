using CleanArch.Appplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Appplication.Interfaces
{
    public interface ICourseService
    {
        CourseViewModel GetCourses();
    }
}
