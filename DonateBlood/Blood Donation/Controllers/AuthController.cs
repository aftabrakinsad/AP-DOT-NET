using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Blood_Donation.Controllers
{
    [EnableCors("*", "*", "*")]
    public class AuthController : ApiController
    {
        [Route("api/Login")]
        [HttpPost]
        public HttpResponseMessage LoG(LoginDTO login)
        {
            try
            {
                if (login == null)
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound, "Username & Password is not provided");
                }
                if (ModelState.IsValid)
                {
                    var data = AuthService.Authenticate(login.Username, login.Password);

                    if (data != null)
                    {
                        return Request.CreateResponse(HttpStatusCode.Accepted, data);
                    }
                    return Request.CreateResponse(HttpStatusCode.Unauthorized, "Username or password is invalid");
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
