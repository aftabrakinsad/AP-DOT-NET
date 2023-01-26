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
        public HttpResponseMessage Add(GroupDTO g)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var data = GroupService.Add(g);
                    return Request.CreateResponse(HttpStatusCode.OK, new { Msg = "Inserted: ", data });
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
                return Request.CreateResponse(HttpStatusCode.OK, new { Msg = "Blood group lists: ", data });
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
                return Request.CreateResponse(HttpStatusCode.OK, new { Msg = "Result: ", data });
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpDelete]
        [Route("api/group/delete/{id}")]
        public HttpResponseMessage Delete_Group(int id)
        {
            try
            {
                var data = GroupService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, new { Msg = "Selected blood group removed: ", data });
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpPost]
        [Route("api/group/update")]
        public HttpResponseMessage Update_Group(GroupDTO groupDTO)
        {
            try
            {
                var data = GroupService.Update(groupDTO);
                return Request.CreateResponse(HttpStatusCode.OK, new { Msg = "Selected blood group updated: ", data });
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpGet]
        [Route("api/group/{name}")]
        public HttpResponseMessage Get_Single_Group_By_name(string name)
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
        public HttpResponseMessage ADD(DonorDTO d)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var data = DonorService.Add(d);
                    return Request.CreateResponse(HttpStatusCode.OK, new { Msg = "Inserted: ", data });
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
                return Request.CreateResponse(HttpStatusCode.OK, new { Msg = "Blood donor list with group: ", data });
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpGet]
        [Route("api/group/{id}/donor")]
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