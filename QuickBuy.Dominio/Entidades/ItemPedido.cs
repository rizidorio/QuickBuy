namespace QuickBuy.Dominio.Entidades
{
    public class ItemPedido : Entidade
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }

        public override void Validade()
        {
            if (ProdutoId == 0)
                AdicionarMensagem("Selecione um produto.");

            if (Quantidade == 0)
                AdicionarMensagem("A quantidade deve ser maior que zero.");
        }
    }
}
