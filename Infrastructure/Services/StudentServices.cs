using Domain;

namespace Infrastructure;

public class StudentServices
{
    List<Student> students = new List<Student>();

    public List<Student> GetStudents()
    {
        return students;
    }
    public void AddStudent(Student student)
    {
        students.Add(student);
    }

    public void UpdateStudent(Student student1)
    {
        foreach (var it in students)
        {
            if (it.Id == student1.Id)
            {
                it.FirstName = student1.FirstName;
                 it.LastName = student1.LastName;
                it.Address = student1.Address;
                it.BirthDate = student1.BirthDate;  
            }break;
        }
    }

    public void Delete(int id)
    {
        foreach (var it in students)
        {
            if (it.Id == id)
            {
                students.Remove(it);
            }break;
        }
    }

}
