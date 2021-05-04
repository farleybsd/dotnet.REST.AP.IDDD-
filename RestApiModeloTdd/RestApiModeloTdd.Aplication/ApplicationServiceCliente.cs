using RestApiModeloTdd.Aplication.Dtos;
using RestApiModeloTdd.Aplication.Interfaces;
using RestApiModeloTdd.Aplication.Interfaces.Mappers;
using RestApiModeloTdd.Domain.Core.Interfaces.Services;
using System.Collections.Generic;

namespace RestApiModeloTdd.Aplication
{
    public class ApplicationServiceCliente : IApplicationServiceCliente
    {
        private readonly IServiceCliente serviceCliente;
        private readonly IMapperCliente mapperCliente;

        public ApplicationServiceCliente(
            IServiceCliente serviceCliente
            , IMapperCliente mapperCliente
            )
        {
            this.serviceCliente = serviceCliente;
            this.mapperCliente = mapperCliente;
        }

        public void Add(ClienteDTO clienteDTO)
        {
            var cliente = mapperCliente.MapperDtoToEntity(clienteDTO);
            serviceCliente.Add(cliente);
        }

        public IEnumerable<ClienteDTO> GetAll()
        {
            var clientes = serviceCliente.GetAll();
            return mapperCliente.MapperListClientesDto(clientes);
        }

        public ClienteDTO GetById(int id)
        {
            var cliente = serviceCliente.GetById(id);
            return mapperCliente.MapperEntityToDto(cliente);
        }

        public void Remove(ClienteDTO clienteDTO)
        {
            var cliente = mapperCliente.MapperDtoToEntity(clienteDTO);
            serviceCliente.Remove(cliente);
        }

        public void Update(ClienteDTO clienteDTO)
        {
            var cliente = mapperCliente.MapperDtoToEntity(clienteDTO);
            serviceCliente.Update(cliente);
        }
    }
}