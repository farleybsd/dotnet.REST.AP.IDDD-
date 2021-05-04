CREATE TABLE [dbo].[Cliente](
[Id] [int] IDENTITY(1,9) NOT NULL,
[Nome] [VARCHAR](10) NULL,
[Sobrenome] [VARCHAR](15) NULL,
[Email] [VARCHAR](50) NULL,
[DataCadastro] [datetime] NULL,
[IsAtivo] [bit] null

)

/* 
public class Cliente : Base
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool IsAtivo { get; set; }
    }


*/