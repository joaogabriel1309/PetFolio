using PetFolio.Comunicacao.Resposta;

namespace PertFolio.Aplicacao.CasoUso.Pet.BuscarPorId
{
    public class BuscarPetPorIdCasoUso
    {
        public RespostaRegistroPetJson Execute(int id)
        {
            return new RespostaRegistroPetJson
            {
                Id = id,
                Nome = "bento",
                DataNascimento = new DateTime(year: 2021, month: 1, day: 1),
                TipoPet = PetFolio.Comunicacao.Enumerados.TipoPet.Gato
            };
        }
    }
}
