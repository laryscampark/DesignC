using Patterns.ConcreteProduct;
using Patterns.Creator;
using Patterns.Product;

namespace Patterns.ConcreateCreator
{
    public class PlatinumFactory : CartaoFactory
    {
        private int _limiteCredito;
        private int _cobrancaAnual;

        public PlatinumFactory(int limiteCredito, int cobrancaAnual)
        {
            this._limiteCredito = limiteCredito;
            this._cobrancaAnual = cobrancaAnual;
        }
        public override CartaoCredito BuscarCartaoCredito()
        {
            return new CartaoPlatinum(_limiteCredito, _cobrancaAnual);
        }
    }
}

