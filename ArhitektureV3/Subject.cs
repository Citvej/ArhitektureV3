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
    public class Subject
    {
        [DataMember]
        public int idSubject;
        [DataMember]
        public string name;
        [DataMember]
        public User izvajalec;

        public Subject(int idSubject, string name, User izvajalec)
        {
            this.idSubject = idSubject;
            this.name = name;
            this.izvajalec = izvajalec;
        }
    }
}