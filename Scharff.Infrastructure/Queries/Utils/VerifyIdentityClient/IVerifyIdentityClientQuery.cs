using Scharff.Domain.Entities;

namespace Scharff.Infrastructure.Queries.Utils.VerifyIdentityClient
{
    public interface IVerifyIdentityClientQuery
    {
        Task<ClientModel> VerifyIdentityClient(string? numberDocumentIdentity);
    }
}
