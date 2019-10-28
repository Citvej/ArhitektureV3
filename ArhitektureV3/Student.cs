using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Serialization;
using System.Web.Http;

namespace ArhitektureV3
{
    [DataContract]
    public class Student
    {
        [DataMember]
        public string idStudent;
        [DataMember]
        public User user;

        public Student() { }

        public Student(string idStudent, User user)
        {
            this.idStudent = idStudent;
            this.user = user;
            user.type = userType.student;


        }
    }
}