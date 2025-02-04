using PetFolio.Comunicacao.Resposta;
using PetFolio.Comunicacao.Solicitacao;

namespace PertFolio.Aplicacao.CasoUso.Pet.Atualizar
{
    public class AtualizarPetCasoUso
    {
        public RespostaPetJson Executar(int id, SolicitacaoPetJson registroPetJson)
        {
            return new RespostaPetJson
            {
                Id = id,
                Nome = registroPetJson.Nome
            };
        }
    }
}
