using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Routing;

namespace Health_Care_360_.Controllers
{
    public class BedController : ApiController
    {
        //.....For Adding Beds Category and Lists of Bed in Category
        [Route("api/Bed/AddCategory")]
        [HttpPost]
        public HttpResponseMessage AddCategory(BedCategoryDTO bedCategory)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var data = BedService.AddCategory(bedCategory);
                    return Request.CreateResponse(HttpStatusCode.OK, data);
                }return Request.CreateResponse(HttpStatusCode.Ambiguous, "No value inserted");
            
            }
            catch(Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }
       
        [Route("api/Bed/Category/AddBeds")]
        [HttpGet]
        public HttpResponseMessage AddBedsInCategory()
        {
            try
            {
                var data=BedService.GetCategory();
                return Request.CreateResponse(HttpStatusCode.Accepted, data);
            }catch(Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }
        [Route("api/Bed/Category/AddBeds")]
        [HttpPost]
        public HttpResponseMessage AddBedsInCategory(BedDTO beds)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var data = BedService.AddBedsInCategory(beds);
                    return Request.CreateResponse(HttpStatusCode.Accepted, data);
                }
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "no data given");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }
        [Route("api/Bed/Category/{id}")]
        [HttpGet]
        public HttpResponseMessage ShowBeds(int id)
        {
            try
            {
                var data = BedService.ShowBeds(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch(Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.NoContent, ex);
            }
        }
        //......For Adding Allotment in Beds
        [Route("api/Bed/AddAllotment/{id}")]
        [HttpGet]
        public HttpResponseMessage AddAllotment()
        {
            try
            {
                var data = PatientService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch(Exception ex) {
                return Request.CreateResponse(HttpStatusCode.NoContent, ex);
            }
        }
        [Route("api/Bed/AddAllotment/{id}")]
        [HttpPost]
        public HttpResponseMessage AddAllotment(BedAllotmentDTO bedAllotment,int id)
        {
            try
            {
                var data = BedAllotmentService.AddAllotment(bedAllotment,id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.NoContent, ex);
            }
        }
        [Route("api/Bed/EditAllotments/{id}")]
        [HttpGet]
        public HttpResponseMessage EditAllotment(int id)
        {
            try
            {
                var data = BedAllotmentService.GetAllotment(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.NoContent, ex);
            }
        }
        [Route("api/Bed/EditAllotments/{id}")]
        [HttpPost]
        public HttpResponseMessage EditAllotment(BedAllotmentDTO bedAllotment)
        {
            try
            {
                var data = BedAllotmentService.EditAllotment(bedAllotment);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.NoContent, ex);
            }
        }
        [Route("api/Bed/Allotments")]
        [HttpGet]
        public HttpResponseMessage Allotment()
        {
            try
            {
                var data = BedAllotmentService.GetAllotment();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.NoContent, ex);
            }
        }
    }
}
