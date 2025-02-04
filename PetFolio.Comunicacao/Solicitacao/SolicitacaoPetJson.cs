using PetFolio.Comunicacao.Enumerados;

namespace PetFolio.Comunicacao.Solicitacao
{
    public class SolicitacaoPetJson
    {
        public string Nome {  get; set; } = string.Empty;
        public DateTime DataNascimento { get; set; }
        public TipoPet TipoPet { get; set; }
    }
}
