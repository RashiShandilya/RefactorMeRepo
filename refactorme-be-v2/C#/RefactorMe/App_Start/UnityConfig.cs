using RefactorMe.DontRefactor.Data;
using RefactorMe.DontRefactor.Data.Implementation;
using RefactorMe.DontRefactor.Models;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace RefactorMe
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
           container.RegisterType(typeof(IReadOnlyRepository<Lawnmower>), typeof(BaseReadOnlyRepository<Lawnmower>));
            container.RegisterType(typeof(IReadOnlyRepository<PhoneCase>), typeof(BaseReadOnlyRepository<PhoneCase>));
            container.RegisterType(typeof(IReadOnlyRepository<TShirt>), typeof(BaseReadOnlyRepository<TShirt>));

            // no specific registration needed for the specific type resolves
            container.Resolve(typeof(IReadOnlyRepository<Lawnmower>));
            container.Resolve(typeof(IReadOnlyRepository<PhoneCase>));
            container.Resolve(typeof(IReadOnlyRepository<TShirt>));


            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}