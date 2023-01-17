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
        [Route("api/donor/add")]
        public HttpResponseMessage Register(DonorDTO p)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var data = DonorService.Add(p);
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
        [Route("api/donors")]
        public HttpResponseMessage Get()
        {
            try
            {
                var data = DonorService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpGet]
        [Route("api/donor/{id}")]
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

        [HttpDelete]
        [Route("api/donor/delete/{id}")]
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
        [Route("api/donor/update")]
        public HttpResponseMessage Update_Donor(DonorDTO donorDTO)
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
        [Route("api/donorss/{name}")]
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
