using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        [Key]
        public string idStudent { get; set; }
        [DataMember]

        //public int id { get; set; }
        //[ForeignKey("User")]
        public User user { get; set; }

        public virtual ICollection<Student_Subject> Student_Subjects { get; set; }
        
        public Student() { }

        public Student(string idStudent, User user)
        {
            this.idStudent = idStudent;
            this.user = user;
            user.type = userType.student;
        }
    }
}