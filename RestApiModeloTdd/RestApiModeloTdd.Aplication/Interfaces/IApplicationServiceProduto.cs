using RestApiModeloTdd.Aplication.Dtos;
using System.Collections.Generic;

namespace RestApiModeloTdd.Aplication.Interfaces
{
    public interface IApplicationServiceProduto
    {
        void Add(ProdutoDTO produtoDTO);

        void Update(ProdutoDTO produtoDTO);

        void Remove(ProdutoDTO produtoDTO);

        IEnumerable<ProdutoDTO> GetAll();

        ProdutoDTO GetById(int id);
    }
}