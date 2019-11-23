using ArhitektureV3;
using System.Data.Entity;

public class MoviesDBInitializer : DropCreateDatabaseAlways<FeriContext>
{
    protected override void Seed(FeriContext context)
    {
        User user0 = new User("userName0", "pass123", "student1", "surname1", "student");
        User user1 = new User("userName1", "pass1234", "student2", "surname1", "student");
        User user2 = new User("userName2", "pass1235", "student3", "surname1", "student");
        User user3 = new User("userName3", "pass1", "student4", "surname1", "student");
        User user4 = new User("userName4", "pass123", "name1", "surname1", "student");
        User user5 = new User("userName5", "pass123", "name1", "surname1", "student");
        User user6 = new User("userName6", "pass123", "name1", "surname1", "student");
        User user7 = new User("userName7", "pass123", "name1", "surname1", "profesor");
        User user8 = new User("userName8", "pass123", "name1", "surname1", "profesor");
        User user9 = new User("userName9", "pass123", "name1", "surname1", "referent");

        context.Users.Add(user0);
        context.Users.Add(user1);
        context.Users.Add(user2);
        context.Users.Add(user3);
        context.Users.Add(user4);
        context.Users.Add(user5);
        context.Users.Add(user6);
        context.Users.Add(user7);
        context.Users.Add(user8);
        context.Users.Add(user9);

        Student student1 = new Student("E0000000", user0);
        Student student2 = new Student("E0000001", user1);
        Student student3 = new Student("E0000002", user2);
        Student student4 = new Student("E0000003", user3);

        context.Students.Add(student1);
        context.Students.Add(student2);
        context.Students.Add(student3);
        context.Students.Add(student4);

        Subject programiranje1 = new Subject("Programiranje1", user7);
        Subject programiranje2 = new Subject("Programiranje2", user8);

        context.Subjects.Add(programiranje1);
        context.Subjects.Add(programiranje2);

        Student_Subject student_subject1 = new Student_Subject(student1, programiranje1);
        Student_Subject student_subject2 = new Student_Subject(student1, programiranje2);
        Student_Subject student_subject4 = new Student_Subject(student2, programiranje2);

        context.SaveChanges();

        //List<User> users = new List<User>() { user0, user1, user2, user3, user4, user5, user6, user7, user8, user9 };
        //List<Student> students = new List<Student>() { student1, student2, student3, student4 };
        //List<Subject> subjects = new List<Subject>() { programiranje1, programiranje2 };

        //List<Student_Subject> razred_ucenec = new List<Student_Subject>() { student_subject1, student_subject2, student_subject4 };

        User loggedInUser = null;


        base.Seed(context);

    }
}