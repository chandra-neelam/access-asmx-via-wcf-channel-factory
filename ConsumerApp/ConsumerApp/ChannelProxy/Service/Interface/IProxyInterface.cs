using ConsumerApp.ChannelProxy.Service.Models;
using System.ServiceModel;

namespace ConsumerApp.ChannelProxy.Service.Interface
{
    [ServiceContractAttribute(ConfigurationName = "IProxyInterface")]
    public interface IProxyInterface
    {
        [OperationContractAttribute(Action = "http://tempuri.org/Login", ReplyAction = "*")]
        LoginResponse Login(LoginRequest request);
    }
}
