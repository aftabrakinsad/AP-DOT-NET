using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BloodDonate.Controllers
{
    public class UserController : ApiController
    {
        [Route("api/users")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            var data = UserService.GetUsers();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/users/add")]
        [HttpPost]
        public HttpResponseMessage Add(UserDTO people)
        {
            var data = UserService.Add(people);
            if (data != null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            return Request.CreateResponse(HttpStatusCode.InternalServerError);
        }

        [Route("api/users/update/{name}")]
        [HttpPost]
        public HttpResponseMessage Upda(UserDTO udon)
        {
            var resp = UserService.Update(udon);
            if (resp)
            {
                return Request.CreateResponse(HttpStatusCode.OK, new { msg = "Updated", data = udon });
            }
            return Request.CreateResponse(HttpStatusCode.InternalServerError);
        }

        [Route("api/users/delete/{uname}")]
        [HttpDelete]
        public HttpResponseMessage Delete(string uname)
        {
            var resp = UserService.Delete(uname);
            if (resp)
            {
                return Request.CreateResponse(HttpStatusCode.OK, new { msg = "Deleted", data = uname });
            }
            return Request.CreateResponse(HttpStatusCode.InternalServerError);
        }
    }
}
