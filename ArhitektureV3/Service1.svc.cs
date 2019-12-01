using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ArhitektureV3
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    [ServiceBehavior]
    public class Service1 : IService1
    {

        //static User user0 = new User("userName0", "pass123", "student1", "surname1", "student");
        //static User user1 = new User("userName1", "pass1234", "student2", "surname1", "student");
        //static User user2 = new User("userName2", "pass1235", "student3", "surname1", "student");
        //static User user3 = new User("userName3", "pass1", "student4", "surname1", "student");
        //static User user4 = new User("userName4", "pass123", "name1", "surname1", "student");
        //static User user5 = new User("userName5", "pass123", "name1", "surname1", "student");
        //static User user6 = new User("userName6", "pass123", "name1", "surname1", "student");
        //static User user7 = new User("userName7", "pass123", "name1", "surname1", "profesor");
        //static User user8 = new User("userName8", "pass123", "name1", "surname1", "profesor");
        //static User user9 = new User("userName9", "pass123", "name1", "surname1", "referent");

        //static Student student1 = new Student("E0000000", user0);
        //static Student student2 = new Student("E0000001", user1);
        //static Student student3 = new Student("E0000002", user2);
        //static Student student4 = new Student("E0000003", user3);

        //static Subject programiranje1 = new Subject("Programiranje1", user7);
        //static Subject programiranje2 = new Subject("Programiranje2", user8);

        //static Student_Subject student_subject1 = new Student_Subject(student1, programiranje1);
        //static Student_Subject student_subject2 = new Student_Subject(student1, programiranje2);
        //static Student_Subject student_subject4 = new Student_Subject(student2, programiranje2);

        //static List<User> users = new List<User>() { user0, user1, user2, user3, user4, user5, user6, user7, user8, user9 };
        //static List<Student> students = new List<Student>() { student1, student2, student3, student4 };
        //static List<Subject> subjects = new List<Subject>() { programiranje1, programiranje2 };

        //static List<Student_Subject> razred_ucenec = new List<Student_Subject>() { student_subject1, student_subject2, student_subject4 };


        static User loggedInUser = null;
        static FeriContext context = new FeriContext();

        public int AddStudent(string idStudent, string username, string password, string name, string surname)
        {
            Student student; ;
            User user;

            user = new User(username, password, name, surname, "student");
            student = new Student(idStudent, user);

            context.Students.Add(student);

            return context.SaveChanges(); ;
        }

        public int AddUser(string usernam, string passwor, string name, string surname, string type)
        {
            User user = new User(usernam, passwor, name, surname, type);
            context.Users.Add(user);
            return context.SaveChanges();
        }

        public int AddSubject(string subjectName)
        {
            Subject subject = new Subject(subjectName, new User());
            context.Subjects.Add(subject);

            return context.SaveChanges();
        }

        public List<User> GetUsers()
        {
            List<User> users = context.Users.ToList();

            if (loggedInUser == null) return new List<User>();

            return users;
            
        }

        public int AddStudentSubject(string idStudent, int idSubject)
        {
            Student st;
            Subject su;
            Student_Subject ss;
            
            st = context.Students.Find(idStudent);
            su = context.Subjects.Find((int)idSubject);

            ss = new Student_Subject(st, su);

            context.Student_Subjects.Add(ss);
            
            return context.SaveChanges();
        }

        public int EditStudent(string idStudent,string name)
        {
            Student student;

            student = context.Students.Find(idStudent);

            if (student == null) return 0;

            student.user.name = name;
            context.Students.Attach(student);

            return context.SaveChanges();
        }

        public int EditSubject(int idSubject, string name)
        {
            Subject subject;

            subject = context.Subjects.Find(idSubject);

            if (subject == null) return 0;

            Console.WriteLine("Vnesi novo ime: ");
            name = Console.ReadLine();

            subject.name = name;
            context.Subjects.Attach(subject);

            return context.SaveChanges();
        }

        public int EditUser(int idUser, string name)
        {
            User user;

            user = context.Users.Find(idUser);

            if (user == null) return 0;

            user.name = name;
            context.Users.Attach(user);

            return context.SaveChanges();
        }

        public int DeleteStudent(string id) 
        {
            Student s = context.Students.Find(id);
            context.Students.Remove(s);

            return context.SaveChanges();
        }

        public int DeleteUser(int id)
        {
            //var itemToRemove = context.Users.SingleOrDefault(x => x.id == id);
            User u = context.Users.Find(id);
            context.Users.Attach(u);
            context.Users.Remove(u);

            return context.SaveChanges();
        }

        public int DeleteSubject(int id)
        {
            Subject s = context.Subjects.Find(id);
            context.Subjects.Remove(s);

            return context.SaveChanges();
        }

        public int DeleteStudentSubject(int id)
        {
            Student_Subject ss = context.Student_Subjects.Find(id);
            context.Student_Subjects.Remove(ss);

            return context.SaveChanges();
        }

        public int AddUserToSubject(int idUser, int idSubject)
        {
            User u = context.Users.Find(idUser);
            Subject s = context.Subjects.Find(idSubject);

            s.izvajalec = u;

            context.Subjects.Attach(s);

            return context.SaveChanges();
        }

        public float GetAverageNameLength()
        {
            List<User> users = context.Users.ToList<User>();
            float result = 0f;

            if (loggedInUser == null) return result;


            foreach (User user in users)
            {
                result += user.name.Length / (float)users.Count;
            }
            return result;
        }
        public Student GetBiggestSubject()
        {
            List<Student_Subject> razred_ucenec = context.Student_Subjects.ToList<Student_Subject>();

            Student retn = new Student();
            int count;
            int max = 0;
            
            if (loggedInUser == null) return retn;
            foreach (Student_Subject ss1 in razred_ucenec)
            {
                count = 0;
                foreach(Student_Subject ss2 in razred_ucenec)
                {
                    if (ss1.subject == ss2.subject && ss1.student == ss2.student) count++;
                }
                if (count > max) retn = ss1.student;
            }
            return retn;
        }

        public User GetLongestName()
        {
            List<User> users = context.Users.ToList<User>();

            User retn = new User();
            int max = 0;

            if (loggedInUser == null) return retn;

            foreach (User user in users)
            {
                if (user.name.Length > max)
                {
                    max = user.name.Length;
                    retn = user;
                }
            }
            return retn;
        }

        public Student GetStudent(string id)
        {
            List<Student> students = context.Students.ToList<Student>();

            if (loggedInUser == null) return new Student();

            foreach (Student student in students)
                if (student.idStudent.Contains(id)) return student;
            
            return new Student();
        }

        public List<Student> GetStudents()
        {
            List<Student> students = context.Students.ToList<Student>();

            if (loggedInUser == null) new List<Student>();

            return students;
        }

        public List<Student> GetStudentsFromSubject(int idSubject)
        {
            List<Student_Subject> razred_ucenec = context.Student_Subjects.ToList<Student_Subject>();

            List<Student> retn = new List<Student>();
            if (loggedInUser == null || loggedInUser.type != userType.referent) return retn;

            foreach (Student_Subject ss in razred_ucenec)
            {
                if (ss.subject.idSubject == idSubject) retn.Add(ss.student);
            }
            return retn;
        }

        public List<Subject> GetSubjects()
        {
            List<Subject> subjects = context.Subjects.ToList<Subject>();
            if (loggedInUser == null || loggedInUser.type != userType.referent) new List<Subject>(); ;

            return subjects;
        }

        public List<Subject> GetSubjectsFromStudent(int idStudent)
        {
            List<Student_Subject> razred_ucenec = context.Student_Subjects.ToList<Student_Subject>();

            List< Subject > retn = new List<Subject>();
            if (loggedInUser == null || loggedInUser.type != userType.referent) return retn;

            foreach (Student_Subject ss in razred_ucenec)
            {
                if (ss.subject.idSubject == idStudent) retn.Add(ss.subject);
            }
            return retn;
        }

        public User Login(string username, string password)
        {
            List<User> users = context.Users.ToList<User>();
            foreach(User user in users)
            {
                if (user.username == username && user.password == password)
                {
                    loggedInUser = user;
                    return user;
                }
            }
            return null;
        }
    }
}
