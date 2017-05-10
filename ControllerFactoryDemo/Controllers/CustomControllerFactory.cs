using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.SessionState;

namespace ControllerFactoryDemo.Controllers
{
    public class CustomControllerFactory : IControllerFactory
    {
        public IController CreateController(RequestContext requestContext, string controllerName)
        {
            if (controllerName != "Home")
            {
                throw new HttpException((int)HttpStatusCode.NotFound, "Controller not found.");
            }

            return new HomeController(
                new Models.AppSignature
                {
                    ApplicationName = "Concrete Factory Demo",
                    AuthorName = "Mateusz Byra"
                });
        }

        public SessionStateBehavior GetControllerSessionBehavior(RequestContext requestContext, string controllerName)
        {
            return SessionStateBehavior.Default;
        }

        public void ReleaseController(IController controller)
        {
            if(controller is IDisposable)
            {
                (controller as IDisposable).Dispose();
            }
        }
    }
}