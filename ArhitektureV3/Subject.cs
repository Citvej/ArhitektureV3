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
    public class Subject
    {
        [DataMember]
        [Key]
        public int idSubject { get; set; }
        [DataMember]
        public string name { get; set; }
        
        [DataMember]
        public User izvajalec { get; set; }

        public virtual ICollection<Student_Subject> Student_Subjects { get; set; }

        public Subject(string name, User izvajalec)
        {
            this.name = name;
            this.izvajalec = izvajalec;
        }
    }
}