using SoapDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace SoapDemo
{
    /// <summary>
    /// Summary description for SoapDemo
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class SoapDemo : System.Web.Services.WebService
    {
        [WebMethod]
        public ResponseModel Login(string email, string password)
        {
            ResponseModel response = new ResponseModel();

            if (email != "chandra@gmail.com")
            {
                response.ResultCode = 501;
                response.Message = "User Not Found!!";
            }
            else if (password != "chandra")
            {
                response.ResultCode = 502;
                response.Message = "Invalid Password!!";
            }
            else
            {
                response.ResultCode = 200;
                response.Message = "Login Success!!";
            }
            return response;
        }
    }
}
