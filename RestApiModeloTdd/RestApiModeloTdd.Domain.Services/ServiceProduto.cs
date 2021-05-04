using RestApiModeloTdd.Domain.Core.Interfaces.Repositorys;
using RestApiModeloTdd.Domain.Core.Interfaces.Services;
using RestApiModeloTdd.Domain.Entitys;

namespace RestApiModeloTdd.Domain.Services
{
    public class ServiceProduto : ServiceBase<Produto>, IServiceProduto
    {
        private readonly IRepositoryProduto repositoryProduto;

        public ServiceProduto(IRepositoryProduto repositoryProduto)
            : base(repositoryProduto)
        {
            this.repositoryProduto = repositoryProduto;
        }
    }
}