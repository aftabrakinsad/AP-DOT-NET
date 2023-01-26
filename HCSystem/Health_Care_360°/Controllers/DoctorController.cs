using BLL.DTOs;
using BLL.Services;
using Health_Care_360_.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Xml.Linq;

namespace Health_Care_360_.Controllers
{
    [EnableCors("*","*","*")]
    public class DoctorController : ApiController
    {
        
        [HttpPost]
        [Route("api/doctor/register")]
        public HttpResponseMessage Register(DoctorDTO doctor)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var data = DoctorService.Add(doctor);
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
        [Route("api/doctor/get/all")]
        public HttpResponseMessage GetAllDoctors()
        {
            try
            {
                var data = DoctorService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }


        }

        [HttpGet]
        [Route("api/doctor/get/{id}")]
        public HttpResponseMessage GetSingleDoctor(int id)
        {
            try
            {
                var data = DoctorService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }


        }


        [HttpPost]
        [Route("api/doctor/delete/{id}")]
        public HttpResponseMessage DeleteDoctors(/*DoctorDTO doctor*/ int id)
        {
            try
            {
                var data = DoctorService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }


        }


        [HttpPost]
        [Route("api/doctor/update")]
        public HttpResponseMessage UpdateDoctors(DoctorDTO doctor)
        {
            try
            {
                var data = DoctorService.Update(doctor);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }


        }












        //____________________________________________________________________



        [Logged]
        [HttpGet]
        [Route("api/Doctor/Patients")]
        public HttpResponseMessage AllPatients()
        {
            try
            {
                var data = PatientService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, ex);
            }


        }
        [Logged]
        [HttpGet]
        [Route("api/Doctor/{name}")]
        public HttpResponseMessage AllAppointment(string name)
        {
            try
            {
                var data = AppointMentService.ShowAppointments(name);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch(Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, ex);
            }
                
            
        }
        [Logged]
        [HttpGet]
        [Route("api/Doctor/{name}/{id}")]
        public HttpResponseMessage AddAppointment(int id)
        {
            try
            {
                var data = PatientService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, ex);
            }


        }
        [Logged]
        [HttpPost]
        [Route("api/Doctor/{name}/{id}")]
        public HttpResponseMessage AddAppointment(AppointmentDTO appointment,string name)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var data = AppointMentService.Add(appointment,name);
                    return Request.CreateResponse(HttpStatusCode.OK, data);
                }
                return Request.CreateResponse(HttpStatusCode.NoContent);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, ex);
            }
            
            
        }
        
        
    }
}
