using Patterns.Product;

namespace Patterns.Creator
{
    public abstract class CartaoFactory
    {
        public abstract CartaoCredito BuscarCartaoCredito();
    }
}
