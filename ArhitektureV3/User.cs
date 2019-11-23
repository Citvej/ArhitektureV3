using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Serialization;
using System.Web.Http;

namespace ArhitektureV3
{
    public enum userType { referent, profesor, student };

    [DataContract]
    public class User
    {
        [DataMember]
        [Key]
        public int id { get; set; }
        [DataMember]
        public string username { get; set; }
        [DataMember]
        public string password { get; set; }
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public string surname { get; set; }
        [DataMember]
        public userType type { get; set; }
        
        
        //public int idStudent { get; set; }
        //[ForeignKey("Student")]
        //public virtual Student Student { get; set; }


        public User(string username, string password, string name, string surname, string type)
        {
            this.username = username;
            this.password = password;
            this.name = name;
            this.surname = surname;

            if (type == "student")
                this.type = userType.student;
            else if (type == "referent")
                this.type = userType.referent;
            else if (type == "profesor")
                this.type = userType.profesor;
        }

        public User()
        {
        }
    }
}