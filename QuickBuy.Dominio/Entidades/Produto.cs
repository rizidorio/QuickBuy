namespace QuickBuy.Dominio.Entidades
{
    public class Produto : Entidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public string NomeArquivo { get; set; }
        public override void Validade()
        {
            if (string.IsNullOrEmpty(Nome))
                AdicionarMensagem("Nome do produto não informado");

            if (string.IsNullOrEmpty(Descricao))
                AdicionarMensagem("Descrição do produto não informada");

            if (Preco == 0)
                AdicionarMensagem("Preço do produto deve ser maior que zero");
        }
    }
}
