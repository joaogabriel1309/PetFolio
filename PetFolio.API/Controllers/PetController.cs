using Microsoft.AspNetCore.Mvc;
using PertFolio.Aplicacao.CasoUso.Pet.Atualizar;
using PertFolio.Aplicacao.CasoUso.Pet.BuscarPorId;
using PertFolio.Aplicacao.CasoUso.Pet.ObterTodos;
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
            new AtualizarPetCasoUso().Executar(id, informacaoUsuario);
            return NoContent();
        }

        [HttpGet]
        [ProducesResponseType(typeof(RespostaTodoPetJson), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult ObterTodosPets()
        {
            var resposta = new ObterTodosPetsJson().Executar();
            if (resposta.TodosPets.Any())
            {
                return Ok(resposta);
            }

            return NoContent();
        }

        [HttpGet]
        [Route("id")]
        [ProducesResponseType(typeof(RespostaRegistroPetJson), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult ObterRegistroPets(int id)
        {
            var resposta = new BuscarPetPorIdCasoUso().Execute(id);
            return Ok(resposta);
        }
    }   
}
