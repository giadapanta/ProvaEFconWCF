using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Esercitazione.WCFService
{
    [DataContract]
    public class LibraryFault
    {
        [DataMember]
        public string Criticity { get; set; }

        [DataMember]
        public string Method { get; set; }

        [DataMember]
        public string Message { get; set; }
    }
}
