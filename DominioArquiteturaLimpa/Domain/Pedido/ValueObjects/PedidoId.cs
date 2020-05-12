
namespace DominioArquiteturaLimpa.Domain.ValueObjects
{
    using System;

    public readonly struct PedidoId : IEquatable<PedidoId>
    {
        private readonly Guid _pedidoId;

        public PedidoId(Guid PedidpedidoIdId)
        {
            if (PedidoId == Guid.Empty)
            {
                throw new EmptyPedidoIdException(Messages.pedidoIdCannotBeEmpty);
            }

            this._pedidoId = pedidoId;
        }

        public override string ToString() => this._pedidoId.ToString();

      
        public Guid ToGuid() => this._pedidoId;

      
        public override bool Equals(object obj)
        {
            if (obj is PedidoId pedidoIdObj)
            {
                return this.Equals(pedidoIdObj);
            }

            return false;
        }

      
        public override int GetHashCode() => this._pedidoId.GetHashCode();

        public bool Equals(PedidoId other) => this._pedidoId == other._pedidoId;

        public static bool operator ==(PedidoId left, PedidoId right) => left.Equals(right);

       
        public static bool operator !=(PedidoId left, PedidoId right) => !(left == right);
    }
}
