using System.Runtime.Serialization;

namespace Esercitazione.Library.Entities
{
    [DataContract]
    public class Book
    {
        
        [DataMember]
        
        public string ISBN { get; set; }
        [DataMember]
        public string Titolo { get; set; }
        [DataMember]
        public string Sommario { get; set; }
        [DataMember]
        public string Autore { get; set; }

    }
}
