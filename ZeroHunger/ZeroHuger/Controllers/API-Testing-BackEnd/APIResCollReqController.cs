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
    public class APIResCollReqController : ApiController
    {
        [HttpPost]
        [Route("api/restaurantCollectionRequest/add")]
        public HttpResponseMessage Add(Restaurant_Collection_requestDTO rescollreqacc)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var data = Res_Coll_req_Service.Add(rescollreqacc);
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
        [Route("api/restaurantCollectionRequest/list")]
        public HttpResponseMessage Get_All_Request()
        {
            try
            {
                var data = Res_Coll_req_Service.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpGet]
        [Route("api/restaurantCollectionRequest/{id}")]
        public HttpResponseMessage Get_Single_Request(int id)
        {
            try
            {
                var data = Res_Coll_req_Service.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpDelete]
        [Route("api/restaurantCollectionRequest/delete/{id}")]
        public HttpResponseMessage Delete_Request_By_ID(int id)
        {
            try
            {
                var data = Res_Coll_req_Service.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpPost]
        [Route("api/restaurantCollectionRequest/update")]
        public HttpResponseMessage Update_Request(Restaurant_Collection_requestDTO recollreqacc)
        {
            try
            {
                var data = Res_Coll_req_Service.Update(recollreqacc);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpGet]
        [Route("api/restaurantCollectionRequest/list/count")]
        public HttpResponseMessage All_Rrequest_Count()
        {
            try
            {
                var data3 = Res_Coll_req_Service.Get().Count;
                List<int> numberList = new List<int>() { data3 };
                return Request.CreateResponse(HttpStatusCode.OK, numberList);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        /*[HttpGet]
        [Route("api/restaurantCollectionRequest/get/{id}")]
        public HttpResponseMessage Get_Single_Accepted_Request_By_ID(int id)
        {
            try
            {
                var data = Res_Coll_req_Service.GetChecker(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }*/
    }
}