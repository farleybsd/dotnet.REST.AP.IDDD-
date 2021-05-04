CREATE TABLE [dbo].[Produto](
[Id] [int] IDENTITY(1,9) NOT NULL,
[Nome] [VARCHAR](100) NULL,
[Valor] decimal(18,2) NULL,
[IsDisponivel] [bit] null

)

/* 
public class Produto : Base
    {
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public bool IsDisponivel { get; set; }
    }
*/