using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipaySecurityRiskHideDeviceidQueryResponse.
    /// </summary>
    public class AlipaySecurityRiskHideDeviceidQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 设备指纹的apdid
        /// </summary>
        [JsonProperty("deviceid")]
        [XmlElement("deviceid")]
        public string Deviceid { get; set; }
    }
}
