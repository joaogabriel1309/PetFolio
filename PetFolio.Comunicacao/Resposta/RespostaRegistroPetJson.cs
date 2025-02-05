using PetFolio.Comunicacao.Enumerados;

namespace PetFolio.Comunicacao.Resposta
{
    public class RespostaRegistroPetJson
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public DateTime DataNascimento { get; set; }
        public TipoPet TipoPet { get; set; }

    }
}
