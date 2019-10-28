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
    public class Student_Subject
    {
        [DataMember]
        public int id;
        [DataMember]
        public Student student;
        [DataMember]
        public Subject subject;

        public Student_Subject(int id, Student student, Subject subject)
        {
            this.id = id;
            this.student = student;
            this.subject = subject;
        }


    }
}