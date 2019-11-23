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
    public class Student_Subject
    {
        [DataMember]
        [Key]
        public int id { get; set; }
        
        [DataMember]
        [Key, Column(Order = 1)]
        public Student student { get; set; }
        
        [DataMember]
        [Key, Column(Order = 2)]
        public Subject subject { get; set; }

        //public Student Students { get; set; }
        //public Subject Subjects { get; set; }


        public Student_Subject(Student student, Subject subject)
        {
            this.student = student;
            this.subject = subject;
        }


    }
}