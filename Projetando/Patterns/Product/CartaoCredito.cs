namespace Patterns.Product
{
    public abstract class CartaoCredito
    {
        public abstract string TipoCartao { get;}
        public abstract int LimiteCartao { get; set; }
        public abstract int CobrancaAnual { get; set; }
    }
}
