using System.Xml.Serialization;
using soap.Model.SOAP.Partials;

namespace soap.SOAP.Model
{
    [XmlRoot("Envelope", Namespace = SOAPconstants.SOAP1_1Namespace)]
    public class SOAPResponseEnvelope
    {
        protected SOAPResponseBody? _body;

        public SOAPResponseBody? Body
        {
            get 
            {
                if (_body is null)
                {
                    _body = new SOAPResponseBody();
                }
                return _body;
            }
            set {_body = value;}
        }
    }
}