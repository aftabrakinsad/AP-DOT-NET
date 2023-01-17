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
        [Route("api/group/add")]
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
        [Route("api/group/list")]
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
        [Route("api/group/{id}")]
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
        [Route("api/group/delete/{id}")]
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
        [Route("api/group/update")]
        public HttpResponseMessage UpdatePolice(GroupDTO groupDTO)
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
        [Route("api/groups/{name}")]
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

        [HttpPost]
        [Route("api/group/donor/Add")]
        public HttpResponseMessage ADD(DonorDTO c)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var data = DonorService.Add(c);
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
        [Route("api/group/donorlist")]
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

        [HttpGet]
        [Route("api/donors/{id}")]
        public HttpResponseMessage Get_Single_Donor(int id)
        {
            try
            {
                var data = DonorService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpPost]
        [Route("api/donors/remove/{id}")]
        public HttpResponseMessage Delete_Donor(int id)
        {
            try
            {
                var data = DonorService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpPost]
        [Route("api/donors/update")]
        public HttpResponseMessage UpdateCase(DonorDTO donorDTO)
        {
            try
            {
                var data = DonorService.Update(donorDTO);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpGet]
        [Route("api/donors/{id}/group")]
        public HttpResponseMessage Get_with_Donor(int id)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, GroupService.Get_with_Donor(id));
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
    }
}
