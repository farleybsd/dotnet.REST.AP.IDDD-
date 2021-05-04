using RestApiModeloTdd.Domain.Core.Interfaces.Repositorys;
using RestApiModeloTdd.Domain.Core.Interfaces.Services;
using RestApiModeloTdd.Domain.Entitys;

namespace RestApiModeloTdd.Domain.Services
{
    public class ServiceCliente : ServiceBase<Cliente>, IServiceCliente
    {
        private readonly IRepositoryCliente repositoryCliente;

        public ServiceCliente(IRepositoryCliente repositoryCliente)
            : base(repositoryCliente)
        {
            this.repositoryCliente = repositoryCliente;
        }
    }
}