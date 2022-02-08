using ConsumerApp.ChannelProxy.Service.Models;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace ConsumerApp.ChannelProxy
{
    public class Request
    {
        [MessageBodyMemberAttribute(Name = "Login", Namespace = "http://tempuri.org/", Order = 0)]
        public LoginRequest Body;

        public Request()
        {
        }

        public Request(LoginRequest Body)
        {
            this.Body = Body;
        }
    }

    public class Response
    {
        [MessageBodyMemberAttribute(Name = "LoginResponse", Namespace = "http://tempuri.org/", Order = 0)]
        public ResponseBody Body;

        public Response()
        {
        }

        public Response(ResponseBody Body)
        {
            this.Body = Body;
        }
    }

    [DataContractAttribute(Namespace = "http://tempuri.org/")]
    public partial class ResponseBody
    {

        [DataMemberAttribute(EmitDefaultValue = false, Order = 0)]
        public LoginResponse LoginResult;

        public ResponseBody()
        {
        }

        public ResponseBody(LoginResponse LoginResult)
        {
            this.LoginResult = LoginResult;
        }
    }
}
