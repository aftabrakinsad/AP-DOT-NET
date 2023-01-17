using BLL.DTOs;
using BLL.Services;
using Blood_Donation.AuthFilter;
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
    [Logged]
    public class GroupController : ApiController
    {
        [HttpPost]
        [Route("api/group/add")] //Addition of New Blood Group Data
        public HttpResponseMessage Add_Group(GroupDTO p)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var data = GroupService.Add(p);
                    return Request.CreateResponse(HttpStatusCode.OK, data);
                }
                return Request.CreateResponse(HttpStatusCode.NoContent);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpGet]
        [Route("api/group/list")] //Blood Group List
        public HttpResponseMessage Get_All_Group()
        {
            try
            {
                var data = GroupService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpGet]
        [Route("api/group/{id}")] //Search Blood Group by ID
        public HttpResponseMessage Get_Single_Group(int id)
        {
            try
            {
                var data = GroupService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpDelete]
        [Route("api/group/delete/{id}")] //Delect Blood Group by ID
        public HttpResponseMessage DeleteGroup(int id)
        {
            try
            {
                var data = GroupService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpPost]
        [Route("api/group/update")] //Update Blood Group
        public HttpResponseMessage Update_Group(GroupDTO groupDTO)
        {
            try
            {
                var data = GroupService.Update(groupDTO);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpGet]
        [Route("api/groupby/{name}")] //Search Blood Group By Name
        public HttpResponseMessage Get_Single_Group_By_gname(string name)
        {
            try
            {
                var data = GroupService.GetChecker(name);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpGet]
        [Route("api/group/donorlist")] //View Donorlist With Blood Group
        public HttpResponseMessage Get_All_Donor()
        {
            try
            {
                var data = DonorService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }
    }
}
