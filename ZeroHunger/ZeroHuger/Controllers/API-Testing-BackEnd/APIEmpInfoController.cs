using AutoMapper;
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
    public class APIEmpInfoController : ApiController
    {
        [HttpPost]
        [Route("api/employeeInfo/add")]
        public HttpResponseMessage Add(Employee_infoDTO empinfo)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var data = Emp_info_Service.Add(empinfo);
                    return Request.CreateResponse(HttpStatusCode.OK, new { Msg = "Inserted: ", data = empinfo });
                }
                return Request.CreateResponse(HttpStatusCode.NoContent);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpGet]
        [Route("api/employeeInfo/list")]
        public HttpResponseMessage Get_All_Empoyee_Info()
        {
            try
            {
                var data = Emp_info_Service.Get();
                return Request.CreateResponse(HttpStatusCode.OK, new { Msg = "Employee information List: ", data });
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpGet]
        [Route("api/employeeInfo/{id}")]
        public HttpResponseMessage Get_Single_Empoyee_Info(int id)
        {
            try
            {
                var data = Emp_info_Service.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpDelete]
        [Route("api/employeeInfo/delete/{id}")]
        public HttpResponseMessage Delete_Empoyee_Info_By_ID(int id)
        {
            try
            {
                var data = Emp_info_Service.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, new { Msg = "Selected employee is removed: ", data });
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpPost]
        [Route("api/employeeInfo/update")]
        public HttpResponseMessage Update_Empoyee_Info(Employee_infoDTO empinfo)
        {
            try
            {
                var data = Emp_info_Service.Update(empinfo);
                return Request.CreateResponse(HttpStatusCode.OK, new { Msg = "Employee information is updated: ", data });
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpGet]
        [Route("api/employeeInfo/list/count")]
        public HttpResponseMessage All_Empoyee_Info_Count()
        {
            try
            {
                var data3 = Emp_info_Service.Get().Count;
                List<int> numberList = new List<int>() { data3 };
                return Request.CreateResponse(HttpStatusCode.OK, new { Msg = "Total employee count: ", numberList });
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        /*[HttpGet]
        [Route("api/employeeInfo/get/{id}")]
        public HttpResponseMessage Get_Single_Empoyee_Infot_By_ID(int id)
        {
            try
            {
                var data = Emp_info_Service.GetChecker(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }*/
    }
}