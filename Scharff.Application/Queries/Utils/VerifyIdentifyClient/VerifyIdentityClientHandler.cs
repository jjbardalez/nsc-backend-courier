using MediatR;
using Scharff.Domain.Entities;
using Scharff.Infrastructure.Queries.Utils.VerifyIdentityClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scharff.Application.Queries.Utils.VerifyIdentifyClient
{
    public class VerifyIdentityClientHandler : IRequestHandler<VerifyIdentityClientQuery, ClientModel>
    {
        private readonly IVerifyIdentityClientQuery _verifyIdentityClientQuery;
        public VerifyIdentityClientHandler(IVerifyIdentityClientQuery verifyIdentityClientQuery)
        {
            _verifyIdentityClientQuery = verifyIdentityClientQuery;
        }
        public async Task<ClientModel> Handle(VerifyIdentityClientQuery request, CancellationToken cancellationToken)
        {
            var result = await _verifyIdentityClientQuery.VerifyIdentityClient(request.NumberDocumentIdentity);

            if (result == null) throw new Exception("No se encontro el cliente con el numero de documento indicado.");
            return result;
        }
    }
}
