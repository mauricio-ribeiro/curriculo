using ClimaTempo.Repositories;
using ClimaTempo.Repositories.Interfaces;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace ClimaTempo
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            container.RegisterType<IPrevisaoClimaRepository, PrevisaoClimaRepository>();
            container.RegisterType<IEstadoRepository, EstadoRepository>();
            container.RegisterType<ICidadeRepository, CidadeRepository>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}