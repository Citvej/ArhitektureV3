using System;
using System.Collections.Generic;
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
        public int id;
        [DataMember]
        public string username;
        [DataMember]
        public string password;
        [DataMember]
        public bool admin;
        [DataMember]
        public string name;
        [DataMember]
        public string surname;
        [DataMember]
        public userType type { get; set; }

        public User(int id, string username, string password, bool admin, string name, string surname, string type)
        {
            this.id = id;
            this.username = username;
            this.password = password;
            this.admin = admin;
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