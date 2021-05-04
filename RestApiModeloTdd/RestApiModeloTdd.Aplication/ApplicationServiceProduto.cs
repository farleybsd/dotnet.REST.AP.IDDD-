﻿using RestApiModeloTdd.Aplication.Dtos;
using RestApiModeloTdd.Aplication.Interfaces;
using RestApiModeloTdd.Aplication.Interfaces.Mappers;
using RestApiModeloTdd.Domain.Core.Interfaces.Services;
using System.Collections.Generic;

namespace RestApiModeloTdd.Aplication
{
    public class ApplicationServiceProduto : IApplicationServiceProduto
    {
        private readonly IServiceProduto serviceProduto;
        private readonly IMapperProduto mapperProduto;

        public ApplicationServiceProduto(
              IServiceProduto serviceProduto
            , IMapperProduto mapperProduto
            )
        {
            this.serviceProduto = serviceProduto;
            this.mapperProduto = mapperProduto;
        }

        public void Add(ProdutoDTO produtoDTO)
        {
            var produto = mapperProduto.MapperDtoToEntity(produtoDTO);
            serviceProduto.Add(produto);
        }

        public IEnumerable<ProdutoDTO> GetAll()
        {
            var produtos = serviceProduto.GetAll();
            return mapperProduto.MapperListProdutoDto(produtos);
        }

        public ProdutoDTO GetById(int id)
        {
            var produto = serviceProduto.GetById(id);
            return mapperProduto.MapperEntityToDto(produto);
        }

        public void Remove(ProdutoDTO produtoDTO)
        {
            var produto = mapperProduto.MapperDtoToEntity(produtoDTO);
            serviceProduto.Remove(produto);
        }

        public void Update(ProdutoDTO produtoDTO)
        {
            var produto = mapperProduto.MapperDtoToEntity(produtoDTO);
            serviceProduto.Update(produto);
        }
    }
}