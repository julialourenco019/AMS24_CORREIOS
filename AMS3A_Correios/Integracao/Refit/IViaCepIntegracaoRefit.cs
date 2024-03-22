using AMS3A_Correios.Integracao.Response;
using Refit;

namespace AMS3A_Correios.Integracao.Refit
{
    public interface IViaCepIntegracaoRefit
    {
        [Get("/ws/{cep}/json")]
         Task<ApiResponse<ViaCepResponse>> ObterDadosViaCep(string cep);
    }
}