using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ArhitektureV3
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        User Login(string username, string password);
        [OperationContract]
        List<User> GetUsers();
        [OperationContract]
        List<Student> GetStudents();
        [OperationContract]
        List<Subject> GetSubjects();
        [OperationContract]
        List<Student> GetStudentsFromSubject(int idSubject);
        [OperationContract]
        List<Subject> GetSubjectsFromStudent(int id);
        [OperationContract]
        Student GetStudent(string id);
        [OperationContract]
        Student GetBiggestSubject();
        [OperationContract]
        User GetLongestName();
        [OperationContract]
        float GetAverageNameLength();
        [OperationContract]
        int AddStudent(string idStudent, string username, string password, string name, string surname);
        [OperationContract]
        int AddSubject(string subjectName);
        [OperationContract]
        int AddUser(string usernam, string passwor, string name, string surname, string type);
        [OperationContract]
        int AddStudentSubject(string idStudent, int idSubject);
        [OperationContract]
        int EditStudent(string idStudent, string name);
        [OperationContract]
        int EditUser(int idUser, string name);
        [OperationContract]
        int EditSubject(int idSubject, string name);
        [OperationContract]
        int DeleteStudent(string id);
        [OperationContract]
        int DeleteUser(int id);
        [OperationContract]
        int DeleteSubject(int id);
        [OperationContract]
        public int DeleteStudentSubject(int id);
        [OperationContract]
        public int AddUserToSubject(int idUser, int idSubject);

        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
