using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using ZeroHuger.Auth;

namespace ZeroHuger.Controllers.API_Testing
{
    [EnableCors("*", "*", "*")]
    [Logged]
    public class APICollReqAccController : ApiController
    {
        [HttpPost]
        [Route("api/collectionRequestAccept/add")]
        public HttpResponseMessage Add(Collection_req_acceptDTO collreqacc)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var data = Coll_req_acc_Service.Add(collreqacc);
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
        [Route("api/collectionRequestAccept/list")]
        public HttpResponseMessage Get_All_Accepted_Request()
        {
            try
            {
                var data = Coll_req_acc_Service.Get();
                return Request.CreateResponse(HttpStatusCode.OK, new { Msg = "Accepted collection request list: ", data });
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpGet]
        [Route("api/collectionRequestAccept/{id}")]
        public HttpResponseMessage Get_Single_Accepted_Request(int id)
        {
            try
            {
                var data = Coll_req_acc_Service.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpDelete]
        [Route("api/collectionRequestAccept/delete/{id}")]
        public HttpResponseMessage Delete_Accpected_Request_By_ID(int id)
        {
            try
            {
                var data = Coll_req_acc_Service.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, new { Msg = "Accepted collection request removed: ", data });
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpPost]
        [Route("api/collectionRequestAccept/update")]
        public HttpResponseMessage Update_Accpected_Request(Collection_req_acceptDTO collreqacc)
        {
            try
            {
                var data = Coll_req_acc_Service.Update(collreqacc);
                return Request.CreateResponse(HttpStatusCode.OK, new { Msg = "Accepted collection request updated: ", data });
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpGet]
        [Route("api/allAcceptedRequest/list/count")]
        public HttpResponseMessage All_Accpected_Rrequest_Count()
        {
            try
            {
                var data3 = Coll_req_acc_Service.Get().Count;
                List<int> numberList = new List<int>() { data3 };
                return Request.CreateResponse(HttpStatusCode.OK, new { Msg = "Total Accepted Request: ", data = numberList });
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        /*[HttpGet]
        [Route("api/collectionRequestAccept/get/{id}")]
        public HttpResponseMessage Get_Single_Accepted_Request_By_ID(int id)
        {
            try
            {
                var data = Coll_req_acc_Service.GetChecker(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }*/
    }
}