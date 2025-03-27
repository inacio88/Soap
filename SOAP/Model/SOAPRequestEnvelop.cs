using System.Xml.Serialization;

namespace soap.SOAP.Model
{
    [XmlRoot("Envelope", Namespace = SOAPconstants.SOAP1_1Namespace)]
    public partial class SOAPRequestEnvelop
    {
        [XmlElement("Header")]
        public SOAPHeader? Header { get; set; }
        [XmlElement("Body")]
        public SOAPRequestBody? Body { get; set; }
    }
}