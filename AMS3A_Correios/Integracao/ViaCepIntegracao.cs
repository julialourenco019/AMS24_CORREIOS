using AMS3A_Correios.Integracao.Interfaces;
using AMS3A_Correios.Integracao.Refit;
using AMS3A_Correios.Integracao.Response;

namespace AMS3A_Correios.Integracao
{
    public class ViaCepIntegracao : IViaCepIntegracao
    {
        private readonly IViaCepIntegracaoRefit _viaCepIntegracaoRefit;
        public ViaCepIntegracao( IViaCepIntegracaoRefit viaCepIntegracaoRefit)
        {
            _viaCepIntegracaoRefit = viaCepIntegracaoRefit;
        }
        public  async Task<ViaCepResponse> ObterDadosViaCep(string cep)
        {
            var responseData = await _viaCepIntegracaoRefit.ObterDadosViaCep(cep);
            if(responseData != null && responseData.IsSuccessStatusCode)
            {
                  return responseData.Content;
            }

            return null;
        }

    }
}