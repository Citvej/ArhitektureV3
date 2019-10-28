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
        static User user0 = new User(0, "userName0", "pass123", false, "student1", "surname1", "student");
        static User user1 = new User(1, "userName1", "pass1234", false, "student2", "surname1", "student");
        static User user2 = new User(2, "userName2", "pass1235", false, "student3", "surname1", "student");
        static User user3 = new User(3, "userName3", "pass1", false, "student4", "surname1", "student");
        static User user4 = new User(4, "userName4", "pass123", false, "name1", "surname1", "student");
        static User user5 = new User(5, "userName5", "pass123", false, "name1", "surname1", "student");
        static User user6 = new User(6, "userName6", "pass123", false, "name1", "surname1", "student");
        static User user7 = new User(7, "userName7", "pass123", true, "name1", "surname1", "profesor");
        static User user8 = new User(8, "userName8", "pass123", true, "name1", "surname1", "profesor");
        static User user9 = new User(9, "userName9", "pass123", true, "name1", "surname1", "referent");

        static Student student1 = new Student("E0000000", user0);
        static Student student2 = new Student("E0000001", user1);
        static Student student3 = new Student("E0000002", user2);
        static Student student4 = new Student("E0000003", user3);

        static Subject programiranje1 = new Subject(0, "Programiranje1", user7);
        static Subject programiranje2 = new Subject(1, "Programiranje2", user8);

        static Student_Subject student_subject1 = new Student_Subject(0, student1, programiranje1);
        static Student_Subject student_subject2 = new Student_Subject(0, student1, programiranje2);
        static Student_Subject student_subject4 = new Student_Subject(0, student2, programiranje2);
        
        static List<User> users = new List<User>() { user0, user1, user2, user3, user4, user5, user6, user7, user8, user9 };
        static List<Student> students = new List<Student>() { student1, student2, student3, student4 };
        static List<Subject> subjects = new List<Subject>() { programiranje1 ,programiranje2 };

        static List<Student_Subject> razred_ucenec = new List<Student_Subject>() { student_subject1, student_subject2, student_subject4 };

        static User loggedInUser = null;

        public float GetAverageNameLength()
        {
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

            if (loggedInUser == null) return new Student();

            foreach (Student student in students)
                if (student.idStudent.Contains(id)) return student;
            
            return new Student();
        }

        public List<Student> GetStudents()
        {
            if (loggedInUser == null || loggedInUser.type != userType.referent) new List<Student>();

            return students;
        }

        public List<Student> GetStudentsFromSubject(int idSubject)
        {
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
            if (loggedInUser == null || loggedInUser.type != userType.referent) new List<Subject>(); ;

            return subjects;
        }

        public List<Subject> GetSubjectsFromStudent(int idStudent)
        {
            List < Subject > retn = new List<Subject>();
            if (loggedInUser == null || loggedInUser.type != userType.referent) return retn;

            foreach (Student_Subject ss in razred_ucenec)
            {
                if (ss.subject.idSubject == idStudent) retn.Add(ss.subject);
            }
            return retn;
        }

        public User Login(string username, string password)
        {
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
