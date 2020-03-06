using System.Collections.Generic;

namespace QuickBuy.Dominio.Entidades
{
    public class Usuario : Entidade
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public bool Administrador { get; set; }

        /// <summary>
        /// Um usuário pode ter nenhum ou vários pedidos
        /// </summary>

        public virtual ICollection<Pedido> Pedidos { get; set; }

        public override void Validade()
        {
            if (string.IsNullOrEmpty(Email))
                AdicionarMensagem("E-mail não informado.");

            if (string.IsNullOrEmpty(Senha))
                AdicionarMensagem("Senha não informada.");

            if (string.IsNullOrEmpty(Nome))
                AdicionarMensagem("Nome não informado.");
        }
    }
}
