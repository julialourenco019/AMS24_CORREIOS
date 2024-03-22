using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AMS3A_Correios.Model;
using Correios;
using AMS3A_Correios.Integracao.Response;
using AMS3A_Correios.Integracao.Interfaces;



namespace AMS3A_Correios.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CepController : ControllerBase
    {
        private readonly IViaCepIntegracao _viaCepIntegracao;
       public CepController(IViaCepIntegracao viaCepIntegracao)
       {
         _viaCepIntegracao = viaCepIntegracao;
       }

        [HttpGet("{cep}")]
        public async Task<ActionResult<ViaCepResponse>> GetCep(string cep)
        {
           var responseData = await _viaCepIntegracao.ObterDadosViaCep(cep);
            if(responseData == null)
            {
                return BadRequest("Cep não encontrado");
            }
            return Ok(responseData);
        }
       
    } 

}
