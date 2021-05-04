using System;

namespace RestApiModeloTdd.Aplication.Dtos
{
    public class ProdutoDTO
    {
        public int? Id { get; set; }
        public string Nome { get; set; }
        public Decimal Valor { get; set; }
    }
}