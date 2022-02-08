using System.Runtime.Serialization;
using System.ServiceModel;

/// <summary>
/// Request Models:  1) RequestWrapper  2) RequestModel
/// Response Models: 1) ResponseWrapper 2) ResultWrapper 3) ResponseModel
/// NOTE: Prefix Method Name to all methods to avoid conflict (or) keep it in separate namespace
/// </summary>
namespace ConsumerApp.ChannelProxy.Service.Models
{
    #region Request Methods
    [MessageContract(IsWrapped = false)]
    public class RequestWrapper
    {
        [MessageBodyMember(Namespace = "http://tempuri.org/", Order = 0)]
        public RequestModel Login;  // <-- This should be [MethodName] 

        public RequestWrapper()
        {
        }

        public RequestWrapper(RequestModel requestModel)
        {
            this.Login = requestModel;
        }
    }

    [DataContract(Namespace = "http://tempuri.org/")]
    public class RequestModel
    {
        [DataMember(EmitDefaultValue = false, Order = 0)]
        public string email;

        [DataMember(EmitDefaultValue = false, Order = 1)]
        public string password;

        public RequestModel()
        {
        }

        public RequestModel(string email, string password)
        {
            this.email = email;
            this.password = password;
        }
    }
    #endregion

    #region Response Methods
    [MessageContract(IsWrapped = false)]
    public class ResponseWrapper
    {
        [MessageBodyMember(Namespace = "http://tempuri.org/", Order = 0)]
        public ResultWrapper LoginResponse;  // <-- This should be [MethodName]Response

        public ResponseWrapper()
        {
        }

        public ResponseWrapper(ResultWrapper Body)
        {
            this.LoginResponse = Body;
        }
    }

    [DataContract(Namespace = "http://tempuri.org/")]
    public class ResultWrapper
    {
        [DataMember(EmitDefaultValue = false, Order = 0)]
        public ResponseModel LoginResult;  // <-- This should be [MethodName]Result

        public ResultWrapper()
        {
        }

        public ResultWrapper(ResponseModel responseModel)
        {
            this.LoginResult = responseModel;
        }
    }

    [DataContract(Namespace = "http://tempuri.org/")]
    public class ResponseModel
    {
        [DataMember(IsRequired = true)]
        public int ResultCode { get; set; }

        [DataMember(EmitDefaultValue = false, Order = 1)]
        public string Message { get; set; }
    } 
    #endregion
}
