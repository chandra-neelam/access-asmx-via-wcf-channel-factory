using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace ConsumerApp.ChannelProxy.Service.Models
{
    [DataContractAttribute(Name = "ResponseModel", Namespace = "http://tempuri.org/")]
    public class LoginResponse
    {
        [DataMemberAttribute(IsRequired = true)]
        public int ResultCode { get; set; }

        [DataMemberAttribute(EmitDefaultValue = false, Order = 1)]
        public string Message { get; set; }
    }
}
