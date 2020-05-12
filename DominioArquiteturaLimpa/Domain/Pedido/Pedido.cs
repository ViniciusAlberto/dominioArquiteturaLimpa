namespace DominioArquiteturaLimpa.Domain
{
   public abstract class Livro :ILivro{

        public abstract PedidoId PedidoId { get; }

        public abstract PrecoTotal PrecoTotal { get; }

        public abstract LivrosCollection Livrps { get; }

     

   }
}



