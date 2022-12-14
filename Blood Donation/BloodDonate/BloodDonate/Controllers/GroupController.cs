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
    public class GroupController : ApiController
    {
        [Route("api/groups")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            var data = GroupService.GetGroups();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/groups/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            var data = GroupService.Get(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/groups/add")]
        [HttpPost]
        public HttpResponseMessage Post(GroupDTO group)
        {
            var resp = GroupService.Add(group);
            if(resp)
            {
                return Request.CreateResponse(HttpStatusCode.OK, new { msg = "Posted", data = group});
            }
            return Request.CreateResponse(HttpStatusCode.InternalServerError);
        }

        [Route("api/groups/update/{id}")]
        [HttpPost]
        public HttpResponseMessage Up(GroupDTO group)
        {
            var resp = GroupService.Update(group);
            if(resp)
            {
                return Request.CreateResponse(HttpStatusCode.OK, new { msg = "Updated", data = group });
            }
            return Request.CreateResponse(HttpStatusCode.InternalServerError);
        }

        [Route("api/groups/delete/{id}")]
        [HttpDelete]
        public HttpResponseMessage Delete(int id)
        {
            var resp = GroupService.Delete(id);
            if(resp)
            {
                return Request.CreateResponse(HttpStatusCode.OK, new { msg = "Deleted", data = id });
            }
            return Request.CreateResponse(HttpStatusCode.InternalServerError);
        }
    }
}