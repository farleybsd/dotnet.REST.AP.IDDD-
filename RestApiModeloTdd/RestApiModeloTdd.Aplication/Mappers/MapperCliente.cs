using RestApiModeloTdd.Aplication.Dtos;
using RestApiModeloTdd.Aplication.Interfaces.Mappers;
using RestApiModeloTdd.Domain.Entitys;
using System.Collections.Generic;
using System.Linq;

namespace RestApiModeloTdd.Aplication.Mappers
{
    public class MapperCliente : IMapperCliente
    {
        public Cliente MapperDtoToEntity(ClienteDTO clienteDTO)
        {
            var cliente = new Cliente()
            {
                Id = clienteDTO.Id
                ,
                Nome = clienteDTO.Nome
                ,
                Sobrenome = clienteDTO.Sobrenome
                ,
                Email = clienteDTO.Email
            };
            return cliente;
        }

        public ClienteDTO MapperEntityToDto(Cliente cliente)
        {
            var clienteDto = new ClienteDTO()
            {
                Id = cliente.Id
                ,
                Nome = cliente.Nome
                ,
                Sobrenome = cliente.Sobrenome
                ,
                Email = cliente.Email
            };
            return clienteDto;
        }

        public IEnumerable<ClienteDTO> MapperListClientesDto(IEnumerable<Cliente> clientes)
        {
            var dto = clientes.Select(c => new ClienteDTO
            {
                Id = c.Id
                                                                                   ,
                Nome = c.Nome
                                                                                   ,
                Sobrenome = c.Sobrenome
                                                                                   ,
                Email = c.Email
            });
            return dto;
        }
    }
}