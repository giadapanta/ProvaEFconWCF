using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Esercitazione.CoreLibrary.Entities
{
    [DataContract]
    public class Prestito
    {
        [DataMember]
        public string Id { get; set; }
        [DataMember]
        public string IdLibro { get; set; }
        [DataMember]
        public string Utente { get; set; }
        [DataMember]
        public DateTime DataPrestito { get; set; }
        [DataMember]
        public DateTime? DataReso { get; set; }
    }
}
