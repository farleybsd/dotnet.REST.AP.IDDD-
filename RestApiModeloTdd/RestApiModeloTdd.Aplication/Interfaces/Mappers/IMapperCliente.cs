using RestApiModeloTdd.Aplication.Dtos;
using RestApiModeloTdd.Domain.Entitys;
using System.Collections.Generic;

namespace RestApiModeloTdd.Aplication.Interfaces.Mappers
{
    public interface IMapperCliente
    {
        Cliente MapperDtoToEntity(ClienteDTO clienteDTO);

        IEnumerable<ClienteDTO> MapperListClientesDto(IEnumerable<Cliente> clientes);

        ClienteDTO MapperEntityToDto(Cliente cliente);
    }
}