using Newtonsoft.Json;
using RestSharp;

namespace teste.Data

{
    public class BuscaImoveis
    {
        private readonly string _imovelService;
        

        public BuscaImoveis(IConfiguration configuration)
        {
            _imovelService = configuration.GetSection("API").GetSection("BaseUrl").Value;
            
        }

        //getordes envia o que é solicitado pela api
        public async Task<List<ListaImoveis>> GetOrders()
        {
            try
            {
                RestClient client = new($"{_imovelService}/apiteste");
                RestRequest request = new();


               
                request.AddHeader("Accept", "application/json");
                request.AddHeader("Content-Type", "application/json");

                RestResponse response = await client.ExecuteGetAsync(request);
                
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
