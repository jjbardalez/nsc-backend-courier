using Scharff.Domain.Entities;

namespace Scharff.Infrastructure.Queries.Utils.VerifyIdentityClient
{
    public class VerifyIdentityClientQuery : IVerifyIdentityClientQuery
    {
        private readonly HttpClient _client = new HttpClient();

        public async Task<ClientModel> VerifyIdentityClient(string? numberDocumentIdentity)
        {
            string urlApi = "";

            HttpResponseMessage response = await _client.GetAsync(urlApi);

            if (response.IsSuccessStatusCode)
            {
            }

            throw new NotImplementedException();
        }
    }
}
