using RestApiModeloTdd.Aplication.Dtos;
using RestApiModeloTdd.Aplication.Interfaces.Mappers;
using RestApiModeloTdd.Domain.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestApiModeloTdd.Aplication.Mappers
{
    public class MapperProduto : IMapperProduto
    {
        public Produto MapperDtoToEntity(ProdutoDTO produtoDTO)
        {
            var produto = new Produto()
            {
                Id = produtoDTO.Id
                ,
                Nome = produtoDTO.Nome
                ,
                Valor = produtoDTO.Valor
            };
            return produto;
        }

        public ProdutoDTO MapperEntityToDto(Produto produto)
        {
            var produtoDto = new ProdutoDTO()
            {
                Id = produto.Id
               ,
                Nome = produto.Nome
               ,
                Valor = produto.Valor
            };
            return produtoDto;
        }

        public IEnumerable<ProdutoDTO> MapperListProdutoDto(IEnumerable<Produto> produtos)
        {
            var dto = produtos.Select(p => new ProdutoDTO
            {
                Id = p.Id
               ,
                Nome = p.Nome
               ,
                Valor = p.Valor
            });
            return dto;
        }
    }
}
