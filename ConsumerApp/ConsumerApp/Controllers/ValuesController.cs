using ConsumerApp.ChannelProxy;
using ConsumerApp.ChannelProxy.Service.Interface;
using ConsumerApp.ChannelProxy.Service.Models;
using Microsoft.AspNetCore.Mvc;

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
            var req = new Request(new LoginRequest("chandra@gmail.com", "chandra"));
            var result = client.Channel.Login(req);
            return "OK";
        }
    }
}
