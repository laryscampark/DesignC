using Patterns.ConcreteProduct;
using Patterns.Creator;
using Patterns.Product;

namespace Patterns.ConcreateCreator
{
    public class BlackFactory : CartaoFactory
    {
        private int _limiteCredito;
        private int _cobrancaAnual;
        
        public BlackFactory(int limiteCredito, int cobrancaAnual)
        {
            this._limiteCredito = limiteCredito;
            this._cobrancaAnual = cobrancaAnual;
        }
        public override CartaoCredito BuscarCartaoCredito()
        {
            return new CartaoBlack(_limiteCredito, _cobrancaAnual);
        }
    }
}
