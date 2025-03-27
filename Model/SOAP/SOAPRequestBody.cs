using System.Xml.Serialization;
using soap.SOAP.Model;

namespace soap.Model.SOAP
{
    [XmlType(Namespace = SOAPRequestBody.DefaultNameSpace)]
    public partial class SOAPRequestBody
    {
        public const string DefaultNameSpacePrefix = "ser";
        public const string DefaultNameSpace = "http://some.com/service/";
        [XmlElement("GetWetherForecast", Namespace = SOAPRequestBody.DefaultNameSpace)]
        public GetWetherForecastRequest? GetWetherForecast { get; set; }
    }
}