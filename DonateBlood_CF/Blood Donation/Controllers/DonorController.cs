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
    public class DonorController : ApiController
    {
        [HttpPost]
        [Route("api/donor/add")] //Add a Donor
        public HttpResponseMessage Register(DonorDTO p)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var data = DonorService.Add(p);
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
        [Route("api/donor/list")] //View Donor List
        public HttpResponseMessage Get()
        {
            try
            {
                var data = DonorService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, new { Msg = "Blood donor lists: ", data });
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpGet]
        [Route("api/donor/{id}")] //Search Donor By ID
        public HttpResponseMessage Get_Single_Donor(int id)
        {
            try
            {
                var data = DonorService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, new { Msg = "Result: ", data });
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpDelete]
        [Route("api/donor/delete/{id}")] //Delete Donor By ID
        public HttpResponseMessage Delete_Donor(int id)
        {
            try
            {
                var data = DonorService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, new { Msg = "Selected donor is removed: ", data });
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpPost]
        [Route("api/donor/update")] //Update Donor
        public HttpResponseMessage Update_Donor(DonorDTO donorDTO)
        {
            try
            {
                var data = DonorService.Update(donorDTO);
                return Request.CreateResponse(HttpStatusCode.OK, new { Msg = "Selected donor is updated: ", data });
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpGet]
        [Route("api/donorby/{name}")] //Search Donor By Name
        public HttpResponseMessage Get_Single_donor_By_name(string name)
        {
            try
            {
                var data = DonorService.GetChecker(name);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }
    }
}