using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace Health_Care_360_.Auth
{
    public class Logged : AuthorizationFilterAttribute 
    {
        public override void OnAuthorization(HttpActionContext actionContext)
        {
            var Token = actionContext.Request.Headers.Authorization;
            if (Token == null)
            {
                actionContext.Response = actionContext.Request.CreateErrorResponse(System.Net.HttpStatusCode.Unauthorized,"No token Supplied");

            }
            else if (!AuthService.IsValid(Token.ToString()))
            {
                actionContext.Response = actionContext.Request.CreateResponse(System.Net.HttpStatusCode.Unauthorized, "Supplied Token is invalid or expired");
            }
            base.OnAuthorization(actionContext);
        }
    }
}