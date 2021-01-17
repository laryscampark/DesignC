using Patterns.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.ConcreteProduct
{
    public class CartaoPlatinum : CartaoCredito
    {
        private readonly string _tipoConta;
        private int _limiteCredito;
        private int _cobrancaAnual;
        public CartaoPlatinum (int limiteCredito, int cobrancaAnual)
        {
            this._tipoConta = "Platinum";
            this._limiteCredito = limiteCredito;
            this._cobrancaAnual = cobrancaAnual;
        }

        public override string TipoCartao
        {
            get { return _tipoConta; }
        }

        public override int LimiteCartao
        {
            get { return _limiteCredito; }
            set { _limiteCredito = value; }
        }
        public override int CobrancaAnual
        {
            get { return _cobrancaAnual; }
            set { _cobrancaAnual = value; }
        }
    }
}
