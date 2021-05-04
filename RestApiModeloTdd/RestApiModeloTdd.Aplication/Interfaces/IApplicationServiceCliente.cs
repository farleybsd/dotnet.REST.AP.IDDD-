using RestApiModeloTdd.Aplication.Dtos;
using System.Collections.Generic;

namespace RestApiModeloTdd.Aplication.Interfaces
{
    public interface IApplicationServiceCliente
    {
        void Add(ClienteDTO clienteDTO);

        void Update(ClienteDTO clienteDTO);

        void Remove(ClienteDTO clienteDTO);

        IEnumerable<ClienteDTO> GetAll();

        ClienteDTO GetById(int id);
    }
}