using RestApiModeloTdd.Aplication.Dtos;
using RestApiModeloTdd.Domain.Entitys;
using System.Collections.Generic;

namespace RestApiModeloTdd.Aplication.Interfaces.Mappers
{
    public interface IMapperProduto
    {
        Produto MapperDtoToEntity(ProdutoDTO produtoDTO);

        IEnumerable<ProdutoDTO> MapperListProdutoDto(IEnumerable<Produto> produtos);

        ProdutoDTO MapperEntityToDto(Produto produto);
    }
}