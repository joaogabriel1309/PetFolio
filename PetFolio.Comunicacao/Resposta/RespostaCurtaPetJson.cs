using PetFolio.Comunicacao.Enumerados;

namespace PetFolio.Comunicacao.Resposta
{
    public class RespostaCurtaPetJson
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public TipoPet NomeType { get; set; }
    }
}
