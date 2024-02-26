using Domain;

namespace Infrastructure;

public class CourseService
{
    List<Course> _courses = new List<Course>();

    public List<Course> GetCourses()
    {
      return _courses;
    }

    public void AddCourses(Course course)
    {
    
            _courses.Add(course);
    }

    public void UpdateCourse(Course course)
    {
        foreach (var it in _courses)
        {
            if (it.Id == course.Id )
            {
                it.Description = course.Description;
                it.Fee = course.Fee;
                it.Title = course.Title;
                it.HasDisaccount = course.HasDisaccount;
            }
        }
    }

    public void Delete(int id)
    {
        foreach (var it in _courses)
        {
            if (it.Id == id)
            {
                _courses.Remove(it);
            }break;
        }
    }
}
