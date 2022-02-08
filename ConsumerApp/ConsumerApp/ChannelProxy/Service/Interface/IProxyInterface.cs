using ConsumerApp.ChannelProxy.Service.Models;
using System.ServiceModel;

namespace ConsumerApp.ChannelProxy.Service.Interface
{
    [ServiceContract(ConfigurationName = "IProxyInterface")]
    public interface IProxyInterface
    {
        [OperationContract(Action = "http://tempuri.org/Login", ReplyAction = "*")]
        ResponseWrapper Login(RequestWrapper request);
    }
}
