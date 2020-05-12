namespace DominioArquiteturaLimpa.Domain
{

   using System;
    public interface ILivro
    {
        ISBN ISBN{get;set;}

        Nome Nome{get;set;}

        Preco Preco {get;set;}
     

        Autor Autor { get; set; }
    }

}
