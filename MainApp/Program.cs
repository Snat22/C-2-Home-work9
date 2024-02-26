using Domain;
using Infrastructure;

System.Console.WriteLine("Baroi giriftani malumot dar borai Studentxo <<Std>> yo <<Students>> navised dar console:");
System.Console.WriteLine("------------------------------------------------------------------------------------------");
System.Console.WriteLine("Baroi giriftani malumot dar borai Coursxo <<course>> yo <<Courses>> navised dar console:");
System.Console.WriteLine("------------------------------------------------------------------------------------------");
System.Console.WriteLine("Baroi giriftani malumot dar borai Teachers <<teacher>> yo <<Teacher>> navised dar console:");
System.Console.WriteLine("------------------------------------------------------------------------------------------");
System.Console.WriteLine("Baroi giriftani malumot dar borai Posts <<Posts>> yo <<post>> navised dar console:");



string a = Console.ReadLine();
if (a == "Std" || a == "Students") 
{
  

var studentsList = new StudentServices();
var std1 = new Student();
std1.Id = 1;
std1.FirstName = "Muhammad";
std1.LastName = "Samadov";
std1.BirthDate = new DateTime(2006,06,26);
std1.Address = "101mkr N.Sino";


var std2 = new Student();
std2.Id = 2;
std2.FirstName = "Alijon";
std2.LastName = "Zabiri";
std2.BirthDate = new DateTime(2002,12,21);
std2.Address = "DMT  N.Sino";


var std3 = new Student();
std3.Id = 3;
std3.FirstName = "Kabir";
std3.LastName = "Unusov";
std3.BirthDate = new DateTime(2004,03,02);
std3.Address = "Provsoyuz Prokratura";


var std4 = new Student();
std4.Id = 4;
std4.FirstName = "Usuf";
std4.LastName = "Aliev";
std4.BirthDate = new DateTime(2005,06,17);
std4.Address = "Isakndarkul prospect Ayni";

studentsList.AddStudent(std1);
studentsList.AddStudent(std2);
studentsList.AddStudent(std3);
studentsList.AddStudent(std4);

foreach (var it in studentsList.GetStudents())
{
    System.Console.WriteLine(it.Id);
    System.Console.WriteLine(it.FirstName);
    System.Console.WriteLine(it.LastName);
    System.Console.WriteLine(it.BirthDate);
    System.Console.WriteLine(it.Address);
    System.Console.WriteLine("-----------------------------------------------");

}

var updateStd1 = new Student();
updateStd1.Id = 1;
updateStd1.FirstName = "Orzu";
updateStd1.LastName = "Panakov";
updateStd1.BirthDate = new DateTime(2003,04,05);
updateStd1.Address = "Kuchai Mr.AliXamadoni";

  System.Console.WriteLine("Students after updating.");
    studentsList.UpdateStudent(updateStd1);
    
      foreach (var it in studentsList.GetStudents())
      {
        
        System.Console.WriteLine(it.Id);
        System.Console.WriteLine(it.FirstName);
        System.Console.WriteLine(it.LastName);
        System.Console.WriteLine(it.BirthDate);
        System.Console.WriteLine(it.Address);
        System.Console.WriteLine("------------------------------------------------------");
      }
        System.Console.Write("Write Student Id for Delete: ");
        studentsList.Delete(Convert.ToInt32(Console.ReadLine()));
    
    System.Console.WriteLine();
    System.Console.WriteLine("Students after changes:");

    foreach (var it in studentsList.GetStudents())
    {
        System.Console.WriteLine(it.Id);
        System.Console.WriteLine(it.FirstName);
        System.Console.WriteLine(it.LastName);
        System.Console.WriteLine(it.BirthDate);
        System.Console.WriteLine(it.Address);
        System.Console.WriteLine("------------------------------------------------------");

    }

}else if(a == "course"||a == "Courses")
{
  

var course1 = new Course();
course1.Id = 1;
course1.Title = "C#";
course1.Description = "We are Learning";
course1.Fee = 1500;


var course2 = new Course();
course2.Id = 2;
course2.Title = "C++";
course2.Description = "One of the best";
course2.Fee = 1000;


var course3 = new Course();
course3.Id = 3;
course3.Title = "Java";
course3.Description = "For Back";
course3.Fee = 1700;



var course4 = new Course();
course4.Id = 4;
course4.Title = "HTML";
course4.Description = "For Everyone Let's go";
course4.Fee = 700;

var coursesList = new CourseService();

coursesList.AddCourses(course1);
coursesList.AddCourses(course2);
coursesList.AddCourses(course3);
coursesList.AddCourses(course4);

foreach (var it in coursesList.GetCourses())
{
  System.Console.WriteLine($"Course Id: {it.Id}");
  System.Console.WriteLine($"Course Title: {it.Title}");
  System.Console.WriteLine($"Description: {it.Description}");
  System.Console.WriteLine($"Fee: {it.Fee}$");
  System.Console.WriteLine("------------------------------------------------------");
}

var updateCourse = new Course();
updateCourse.Id = 3;
updateCourse.Title = "JS";
updateCourse.Description = "Front-end";
updateCourse.Fee = 400;

var updateCourse2 = new Course();
updateCourse.Id = 1;
updateCourse2.Title = "React";
updateCourse2.Description = "Front-end Framworke";
updateCourse2.Fee = 1400;

coursesList.UpdateCourse(updateCourse);
coursesList.UpdateCourse(updateCourse2);

System.Console.WriteLine("<==============================================");
System.Console.WriteLine("Course After Updating: ");
System.Console.WriteLine("================================================>");
foreach (var it in coursesList.GetCourses())
{
  System.Console.WriteLine($"Course Id: {it.Id}");
  System.Console.WriteLine($"Course Title: {it.Title}");
  System.Console.WriteLine($"Description: {it.Description}");
  System.Console.WriteLine($"Fee: {it.Fee}$");
    System.Console.WriteLine("------------------------------------------------------");

}
System.Console.Write("Write a number for deleting course: ");
coursesList.Delete(Convert.ToInt32(Console.ReadLine()));


System.Console.WriteLine("<==============================================");
System.Console.WriteLine("Course After Changes: ");
System.Console.WriteLine("================================================>");
foreach (var it in coursesList.GetCourses())
{
  System.Console.WriteLine($"Course Id: {it.Id}");
  System.Console.WriteLine($"Course Title: {it.Title}");
  System.Console.WriteLine($"Description: {it.Description}");
  System.Console.WriteLine($"Fee: {it.Fee}$");
    System.Console.WriteLine("------------------------------------------------------");

}
}else if (a == "teacher" || a == "Teacher")
{
  var teachersList = new TeacherService();
  var teacher1 = new Teacher();
  teacher1.Id = 1;
  teacher1.FirstName = "Muhammad";
  teacher1.LastName = "Niyozov";
  teacher1.Position = "C++ Developer";
  teacher1.Experience = 3;

  var teacher2 = new Teacher();
  teacher2.Id = 2;
  teacher2.FirstName = "Faridun";
  teacher2.LastName = "Dodarov";
  teacher2.Position = "Front-End Developer";
  teacher2.Experience = 1;


  var teacher3 = new Teacher();
  teacher3.Id = 3;
  teacher3.FirstName = "Qurbonali";
  teacher3.LastName = "Nazarov";
  teacher3.Position = "C++ Intern";
  teacher3.Experience = 1;

  var teacher4 = new Teacher();
  teacher4.Id = 4;
  teacher4.FirstName = "ALijon";
  teacher4.LastName = "Zabiri";
  teacher4.Position = "C++ Developer and .Net_Developer";
  teacher4.Experience = 4;

teachersList.AddTeacher(teacher1);
teachersList.AddTeacher(teacher2);
teachersList.AddTeacher(teacher3);
teachersList.AddTeacher(teacher4);

System.Console.WriteLine("Teachers List: ");
System.Console.WriteLine();

foreach (var it in teachersList.GetTeacher())
{
  System.Console.WriteLine($"ID: {it.Id}");
  System.Console.WriteLine($"First Name: {it.FirstName}");
  System.Console.WriteLine($"Last Name: {it.LastName}");
  System.Console.WriteLine($"Position: {it.Position}");
  System.Console.WriteLine($"Experience: {it.Experience}");
   System.Console.WriteLine("------------------------------------------------------");

}

  var updateTeacher1 = new Teacher();
  updateTeacher1.Id = 2;
  updateTeacher1.FirstName = "Aziz";
  updateTeacher1.LastName = "Salmonov";
  updateTeacher1.Position = "SMM";
  updateTeacher1.Experience = 8;


  
  var updateTeacher2 = new Teacher();
  updateTeacher2.Id = 4;
  updateTeacher2.FirstName = "Masafi";
  updateTeacher2.LastName = "Jalolov";
  updateTeacher2.Position = "Dveloper";
  updateTeacher2.Experience = 11;
  
  
  System.Console.WriteLine("Updating Teachers :");
  teachersList.UpdateTeacher(updateTeacher1);
  teachersList.UpdateTeacher(updateTeacher2);

    
System.Console.WriteLine("<==============================================");
System.Console.WriteLine("Teachers After Changes: ");
System.Console.WriteLine("================================================>");


foreach (var it in teachersList.GetTeacher())
{
  System.Console.WriteLine($"ID: {it.Id}");
  System.Console.WriteLine($"First Name: {it.FirstName}");
  System.Console.WriteLine($"Last Name: {it.LastName}");
  System.Console.WriteLine($"Position: {it.Position}");
  System.Console.WriteLine($"Experience: {it.Experience}");
   System.Console.WriteLine("------------------------------------------------------");

}
System.Console.WriteLine("For Deleting Teacher write his Id number:");
teachersList.Delete(Convert.ToInt32(Console.ReadLine()));

System.Console.WriteLine("<==============================================");
System.Console.WriteLine("Teachers List After Changes: ");
System.Console.WriteLine("================================================>");
foreach (var it in teachersList.GetTeacher())
{
  System.Console.WriteLine($"ID: {it.Id}");
  System.Console.WriteLine($"First Name: {it.FirstName}");
  System.Console.WriteLine($"Last Name: {it.LastName}");
  System.Console.WriteLine($"Position: {it.Position}");
  System.Console.WriteLine($"Experience: {it.Experience}");
   System.Console.WriteLine("------------------------------------------------------");

}
}else if(a=="Posts" || a=="post")
{
  var posts = new PostService();

  var post1 = new Post();
  post1.Id = 1;
  post1.Title = "SoftClub";
  post1.Description = "One day on SoftClub";
  post1.CreatedAt = new DateTime(2023,12,03);
  post1.VoteAmount = 1;
  post1.VoteAmount = 2;

   var post2 = new Post();
  post2.Id = 2;
  post2.Title = "Weekend";
  post2.Description = "With my Family";
  post2.CreatedAt = new DateTime(2022,01,13);
  post2.VoteAmount = 5;
  post2.VoteAmount = 5;


   var post3 = new Post();
  post3.Id = 3;
  post3.Title = "Party on Tom House";
  post3.Description = "Evryone is cool";
  post3.CreatedAt = new DateTime(2018,09,22);
  post3.VoteAmount = 5;
  post3.VoteAmount = 5;

   var post4 = new Post();
  post4.Id = 4;
  post4.Title = "School";
  post4.Description = "I feeleng good";
  post4.CreatedAt = new DateTime(2024,02,13);
  post4.VoteAmount = 6;
  post4.VoteAmount = 6;

  posts.AddPost(post1);
    posts.AddPost(post2);
      posts.AddPost(post3);
        posts.AddPost(post4);

System.Console.WriteLine("Posts: ");
System.Console.WriteLine();
foreach (var it in posts.GetPosts())
{
  
  System.Console.WriteLine($"ID: {it.Id}");
  System.Console.WriteLine($"First Name: {it.Title}");
  System.Console.WriteLine($"Last Name: {it.Description}");
  System.Console.WriteLine($"Position: {it.VoteAmount}");
  System.Console.WriteLine($"Experience: {it.CreatedAt}");
   System.Console.WriteLine("------------------------------------------------------");
}



   var updatePost = new Post();
  updatePost.Id = 1;
  updatePost.Title = "Owxonai Milli";
  updatePost.Description = "I feeleng good Deliceus ╰(*°▽°*)╯ ";
  updatePost.CreatedAt = new DateTime(2024,01,22);
  updatePost.VoteAmount = 5;
  updatePost.VoteAmount = 3;

  
System.Console.WriteLine("Updating Posts: ");
posts.UpdatePost(updatePost);


System.Console.WriteLine("<==============================================");
System.Console.WriteLine("Posts After Changes: ");
System.Console.WriteLine("================================================>");


foreach (var it in posts.GetPosts())
{
  
  System.Console.WriteLine($"ID: {it.Id}");
  System.Console.WriteLine($"First Name: {it.Title}");
  System.Console.WriteLine($"Last Name: {it.Description}");
  System.Console.WriteLine($"Position: {it.VoteAmount}");
  System.Console.WriteLine($"Experience: {it.CreatedAt}");
  System.Console.WriteLine("------------------------------------------------------");
}


System.Console.Write("For Deleting Post write his Id number: ");
posts.Delete(Convert.ToInt32(Console.ReadLine()));


System.Console.WriteLine("<==============================================");
System.Console.WriteLine("Posts After Changes: ");
System.Console.WriteLine("================================================>");

foreach (var it in posts.GetPosts())
{
  
  System.Console.WriteLine($"ID: {it.Id}");
  System.Console.WriteLine($"First Name: {it.Title}");
  System.Console.WriteLine($"Last Name: {it.Description}");
  System.Console.WriteLine($"Position: {it.VoteAmount}");
  System.Console.WriteLine($"Experience: {it.CreatedAt}");
  System.Console.WriteLine("------------------------------------------------------");
}


} else
{
  System.Console.WriteLine("You vveli nepravilnuyu komandu: ");
}
