using System.Xml.Serialization;

namespace soap.Model.SOAP.Partials
{
    [XmlType(Namespace = SOAPRequestBody.DefaultNameSpace)]
    public partial class SOAPResponseBody
    {
        public const string DefaultNameSpacePrefix = "ser";
        public const string DefaultNameSpace = "http://some.com/service/";
        [XmlElement("GetWetherForecast", Namespace = SOAPRequestBody.DefaultNameSpace)]
        public GetWetherForecastResponse? GetWetherForecast { get; set; }
    }
}