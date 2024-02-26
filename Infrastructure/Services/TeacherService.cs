using Domain;

namespace Infrastructure;

public class TeacherService
{
    List<Teacher> teachers = new List<Teacher>();

     public List<Teacher> GetTeacher()
    {
        return teachers;
    }
    public void AddTeacher(Teacher teacher)
    {
        teachers.Add(teacher);
    }

    public void UpdateTeacher(Teacher teacher)
    {
        foreach (var it in teachers)
        {
            if (it.Id == teacher.Id)
            {
                it.FirstName =teacher.FirstName;
                 it.LastName = teacher.LastName;
                it.Position = teacher.Position;
                it.Experience = teacher.Experience;  
            }break;
        }
    }

    public void Delete(int id)
    {
        foreach (var it in teachers)
        {
            if (it.Id == id)
            {
                teachers.Remove(it);
            }break;
        }
    }


}
