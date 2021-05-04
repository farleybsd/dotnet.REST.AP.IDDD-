using RestApiModeloTdd.Domain.Core.Interfaces.Repositorys;
using RestApiModeloTdd.Domain.Entitys;

namespace RestApiModeloTdd.Infrastruture.Data.Repositorys
{
    public class RepositoryProduto : RepositoryBase<Produto>, IRepositoryProduto
    {
        private SqlContext sqlContext;
        public RepositoryProduto(SqlContext sqlContext)
            : base(sqlContext)
        {
            this.sqlContext = sqlContext;
        }
    }
}
