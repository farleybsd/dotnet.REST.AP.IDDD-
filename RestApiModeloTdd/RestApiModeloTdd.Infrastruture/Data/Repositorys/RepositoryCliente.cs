using RestApiModeloTdd.Domain.Core.Interfaces.Repositorys;
using RestApiModeloTdd.Domain.Entitys;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiModeloTdd.Infrastruture.Data.Repositorys
{
    public class RepositoryCliente : RepositoryBase<Cliente> , IRepositoryCliente
    {
        private readonly SqlContext sqlContext;

        public RepositoryCliente(SqlContext sqlContext)
            :base(sqlContext)
        {
            this.sqlContext = sqlContext;
        }
    }
}
