using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace ConsumerApp.ChannelProxy.Service.Models
{
    [DataContractAttribute(Namespace = "http://tempuri.org/")]
    public class LoginRequest
    {
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false, Order = 0)]
        public string email;

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false, Order = 1)]
        public string password;

        public LoginRequest()
        {
        }

        public LoginRequest(string email, string password)
        {
            this.email = email;
            this.password = password;
        }
    }
}
