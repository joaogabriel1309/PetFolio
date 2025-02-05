using PetFolio.Comunicacao.Resposta;

namespace PertFolio.Aplicacao.CasoUso.Pet.ObterTodos
{
    public class ObterTodosPetsJson
    {
        public RespostaTodoPetJson Executar() 
        {
            return new RespostaTodoPetJson
            {
                TodosPets = new List<RespostaCurtaPetJson> 
                { 
                    new RespostaCurtaPetJson
                    {
                        Id = 1,
                        Nome = "bento",
                        NomeType = PetFolio.Comunicacao.Enumerados.TipoPet.Cachorro
                    }
                }
            };
        }
    }
}
