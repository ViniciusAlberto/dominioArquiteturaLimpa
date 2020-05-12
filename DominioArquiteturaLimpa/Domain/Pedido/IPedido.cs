namespace DominioArquiteturaLimpa.Domain
{

    using System;
    public interface IPedido
    {
        PedidoId PedidoId { get; set; }

        PrecoTotal PrecoTotal { get; set; }

        LivrosCollection Livros { get; set; }
    }

}
