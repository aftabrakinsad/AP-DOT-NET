using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace ZeroHuger.Controllers.API_Testing
{
    [EnableCors("*", "*", "*")]
    public class APIComLoginController : ApiController
    {
        [Route("api/Company/Login")]
        [HttpPost]
        public HttpResponseMessage ComLogin(Company_loginDTO comlogin)
        {
            try
            {
                if (comlogin == null)
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound, "ID & Password is not provided");
                }
                if (ModelState.IsValid)
                {
                    var data = AuthService.Authenticate(comlogin.com_id, comlogin.com_pass);

                    if (data != null)
                    {
                        return Request.CreateResponse(HttpStatusCode.Accepted, data);
                    }
                    return Request.CreateResponse(HttpStatusCode.Unauthorized, "ID or password is invalid");
                }
                return Request.CreateResponse(HttpStatusCode.Forbidden, ModelState);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpGet]
        [Route("api/Logout/{token}")]
        public HttpResponseMessage Logout(string token)
        {
            if (token == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, "Token is not provided");
            }
            var data = AuthService.logout(token);
            if (data != null)
            {
                return Request.CreateResponse(HttpStatusCode.Accepted, data);
            }
            return Request.CreateResponse(HttpStatusCode.Unauthorized, "Token is invalid");
        }
    }
}