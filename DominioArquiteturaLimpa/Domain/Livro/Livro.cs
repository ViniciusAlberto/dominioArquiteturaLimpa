namespace DominioArquiteturaLimpa.Domain
{
   public abstract class Livro :ILivro{

        public abstract ISBN ISBN { get; }

        public abstract Nome Nome { get; }

        public abstract Preco Preco { get; }

         public abstract Autor Autor { get; }


         public bool ValidarEstoque()
         {
             //validação de estoque            

         }

         public Estoque AtualizarEstoque()
         {
             //Adicioanr ou remover Estoque
         }

   }
}



