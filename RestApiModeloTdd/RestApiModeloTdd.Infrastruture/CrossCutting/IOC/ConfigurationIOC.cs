using Autofac;
using RestApiModeloTdd.Aplication;
using RestApiModeloTdd.Aplication.Interfaces;
using RestApiModeloTdd.Aplication.Interfaces.Mappers;
using RestApiModeloTdd.Aplication.Mappers;
using RestApiModeloTdd.Domain.Core.Interfaces.Repositorys;
using RestApiModeloTdd.Domain.Core.Interfaces.Services;
using RestApiModeloTdd.Domain.Services;
using RestApiModeloTdd.Infrastruture.Data.Repositorys;

namespace RestApiModeloTdd.Infrastruture.CrossCutting.IOC
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {
            #region IOC

            builder.RegisterType<ApplicationServiceCliente>().As<IApplicationServiceCliente>();
            builder.RegisterType<ApplicationServiceProduto>().As<IApplicationServiceProduto>();

            builder.RegisterType<ServiceCliente>().As<IServiceCliente>();
            builder.RegisterType<ServiceProduto>().As<IServiceProduto>();

            builder.RegisterType<RepositoryCliente>().As<IRepositoryCliente>();
            builder.RegisterType<RepositoryProduto>().As<IRepositoryProduto>();

            builder.RegisterType<MapperCliente>().As<IMapperCliente>();
            builder.RegisterType<MapperProduto>().As<IMapperProduto>();

            #endregion IOC
        }
    }
}