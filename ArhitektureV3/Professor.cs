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
    public class Professor
    {
        [DataMember]
        public string idProfessor;
        [DataMember]
        public string name;
        [DataMember]
        public string surname;

        public Professor() { }
        public Professor(string idProfessor, string name, string surname)
        {
            this.idProfessor = idProfessor;
            this.name = name;
            this.surname = surname;
        }
    }
}