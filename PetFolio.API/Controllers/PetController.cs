using Microsoft.AspNetCore.Mvc;
using PertFolio.Aplicacao.CasoUso.Pet.Atualizar;
using PertFolio.Aplicacao.CasoUso.Pet.Registrar;
using PetFolio.Comunicacao.Resposta;
using PetFolio.Comunicacao.Solicitacao;

namespace PetFolio.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetController : ControllerBase
    {
        [HttpPost]
        [ProducesResponseType(typeof(RespostaPetJson), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(RespostaErrosJson), StatusCodes.Status400BadRequest)]
        public IActionResult Registrar([FromBody] SolicitacaoPetJson solicitacaoRegistroPetJson)
        {
            var resposta = new RegistrarPetCasoUso().Executar(solicitacaoRegistroPetJson);
            return Created(string.Empty, resposta);
        }

        [HttpPut]
        [Route("id")]
        [ProducesResponseType(typeof(RespostaPetJson), StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(RespostaErrosJson), StatusCodes.Status400BadRequest)]
        public IActionResult Atualizar([FromRoute] int id, [FromBody] SolicitacaoPetJson informacaoUsuario)
        {
            var userCase = new AtualizarPetCasoUso().Executar(id, informacaoUsuario);

            return NoContent();
        }
    }   
}
