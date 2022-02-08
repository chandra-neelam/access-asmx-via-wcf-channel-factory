using ConsumerApp.ChannelProxy.Service.Models;
using System.Reflection;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace ConsumerApp.ChannelProxy
{
    [MessageContractAttribute(IsWrapped = false)]
    public class Request<T>
    {
        [MessageBodyMemberAttribute(Name = "Login", Namespace = "http://tempuri.org/", Order = 0)]
        public T Body;

        public Request()
        {
        }

        public Request(T Body)
        {
            this.Body = Body;
        }
    }

    [MessageContractAttribute(IsWrapped = false)]
    public class Response<T>
    {
        [MessageBodyMemberAttribute(Name = "LoginResponse", Namespace = "http://tempuri.org/", Order = 0)]
        public ResponseBody<T> Body;

        public Response()
        {
        }

        public Response(ResponseBody<T> Body)
        {
            this.Body = Body;
        }
    }

    [DataContractAttribute(Namespace = "http://tempuri.org/")]
    public partial class ResponseBody<T>
    {

        [DataMemberAttribute(Name = "LoginResult", EmitDefaultValue = false, Order = 0)]
        public T Result;

        public ResponseBody()
        {
        }

        public ResponseBody(T Result)
        {
            this.Result = Result;
        }
    }
}
