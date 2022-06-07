using Newtonsoft.Json;
using RestSharp;

namespace teste.Data

{
    public class BuscaImoveis
    {
        private readonly string _imovelService;
        //private readonly string _tokenOrderService;

        public BuscaImoveis(IConfiguration configuration)
        {
            _imovelService = configuration.GetSection("API").GetSection("BaseUrl").Value;
            //_tokenOrderService = configuration.GetSection("OrderService").GetSection("Token").Value;
        }

        //getordes envia o que é solicitado pela api
        public async Task<List<ListaImoveis>> GetOrders()
        {
            try
            {
                RestClient client = new($"{_imovelService}/apiteste");
                RestRequest request = new();


                /* if (!String.IsNullOrEmpty(status))
                     request.AddParameter("status", status);

                 if (!String.IsNullOrEmpty(synced)) 
                     request.AddParameter("erpSynced", synced); */

                //request.AddParameter("erpErrorLog", "0");

                //request.AddParameter("currentPage", page);
                //se api tiver token, utiliza
                // request.AddHeader("Authorization", $"{_tokenOrderService}");
                request.AddHeader("Accept", "application/json");
                request.AddHeader("Content-Type", "application/json");

                RestResponse response = await client.ExecuteGetAsync(request);
                //verifica se está retornando dados
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    List<ListaImoveis> ImovelServiceModelResponse = JsonConvert.DeserializeObject<List<ListaImoveis>>(response.Content);

                    return ImovelServiceModelResponse;
                }
                else
                    return null;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }


        }
    }
}
