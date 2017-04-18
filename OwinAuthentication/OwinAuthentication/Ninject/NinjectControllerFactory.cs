using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace OwinAuthentication.Ninject
{
    public class NinjectControllerFactory : DefaultControllerFactory
    {
        private IKernel ninjectIkernel;

        public NinjectControllerFactory()
        {
            ninjectIkernel = new StandardKernel();
            AdBinding();

        }

        protected override IController GetControllerInstance(RequestContext resquestContext, Type controllerType)
        {
            return controllerType == null ? null : (IController)ninjectIkernel.Get(controllerType);
        }

        private void AdBinding()
        {
            //ninjectIkernel.Bind<IProduto>().To<ProdutoRepositorio>();
            //ninjectIkernel.Bind<ICategoria>().To<CategoriaRepositorio>();
        }


    }
}