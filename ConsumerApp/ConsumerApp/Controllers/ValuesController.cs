using ConsumerApp.ChannelProxy;
using ConsumerApp.ChannelProxy.Service.Interface;
using ConsumerApp.ChannelProxy.Service.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ConsumerApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ValuesController : ControllerBase
    {
        public ValuesController()
        {
        }

        [HttpGet("GetData")]
        public string GetData()
        {
            var client = new WebServiceClient<IProxyInterface>(@"https://localhost:44367/SoapDemo.asmx");
            var req = new RequestWrapper(new RequestModel("chandra@gmail.com", "chandra"));
            var response = client.Channel.Login(req);
            var result = JsonConvert.SerializeObject(response.LoginResponse.LoginResult);
            return result;
        }
    }
}
