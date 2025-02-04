using PetFolio.Comunicacao.Resposta;
using PetFolio.Comunicacao.Solicitacao;

namespace PertFolio.Aplicacao.CasoUso.Pet.Registrar
{
    public class RegistrarPetCasoUso
    {
        public RespostaPetJson Executar(SolicitacaoPetJson registroPetJson)
        {
            return new RespostaPetJson
            {
                Id = 1,
                Nome = registroPetJson.Nome
            };
        }
    }
}
