using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Health_Care_360_.Controllers
{
    public class PatientController : ApiController
    {

        [HttpPost]
        [Route("api/patient/register")]
        public HttpResponseMessage Register(PatientDTO patient)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var data = PatientService.Add(patient);
                    return Request.CreateResponse(HttpStatusCode.OK, data);
                }
                return Request.CreateResponse(HttpStatusCode.NoContent);
            }
            catch(Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }

        }

        [HttpGet]
        [Route("api/patient/get/all")]
        public HttpResponseMessage GetAllPatients()
        {
            try
            {
                var data = PatientService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch(Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
         

        }

        [HttpGet]
        [Route("api/patient/get/{id}")]
        public HttpResponseMessage GetSinglePatient(int id)
        {
            try
            {
                var data = PatientService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }


        }


        [HttpPost]
        [Route("api/Patient/delete/{id}")]
        public HttpResponseMessage DeletePatients(/*PatientDTO patient*/ int id)
        {
            try
            {
                var data = PatientService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }


        }


        [HttpPost]
        [Route("api/patient/update")]
        public HttpResponseMessage UpdatePatients(PatientDTO patient)
        {
            try
            {
                var data = PatientService.Update(patient);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }


        }


        //_________________________________________________________________________





    }
}
