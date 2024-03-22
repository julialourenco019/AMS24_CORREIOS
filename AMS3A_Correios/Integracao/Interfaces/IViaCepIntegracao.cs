using AMS3A_Correios.Integracao.Response;

namespace AMS3A_Correios.Integracao.Interfaces
{
    public interface IViaCepIntegracao
    {
         Task<ViaCepResponse> ObterDadosViaCep(string cep);
    }
}