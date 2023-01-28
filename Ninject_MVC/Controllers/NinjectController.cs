using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Services.Description;

namespace Ninject_MVC.Controllers
{
    public class NinjectController : DefaultControllerFactory
    {
        private IKernel ninjectKernel;
        public NinjectController()
        {
            ninjectKernel = new StandardKernel();
            AddBinding();
        }

        private void AddBinding()
        {
            ninjectKernel.Bind<IEmailSender>().To<SendEmailFromGmail>();
        }
        
        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            return controllerType == null ? null : (IController)ninjectKernel.Get(controllerType);
        }
    }
}