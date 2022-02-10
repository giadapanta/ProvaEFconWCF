using System;
using System.Collections.Generic;
using System.Runtime.Serialization;   //serializza le info necessarie per la creazione di wsdl
using System.Text;

namespace AcademyA_CDO.Week3.CoreLibrary.Entities
{
    [DataContract]
    public class Employee
    {       
       
            [DataMember]
            public string Id { get; set; }

            [DataMember]
            public string FirstName { get; set; }

            [DataMember]
            public string LastName { get; set; }

        [DataMember]
        public string EmployeeCode { get; set; }
        
    }
}
