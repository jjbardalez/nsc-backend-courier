using MediatR;
using Scharff.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scharff.Application.Queries.Utils.VerifyIdentifyClient
{
    public class VerifyIdentityClientQuery : IRequest<ClientModel>
    {
        public string? NumberDocumentIdentity { get; set; }
    }
}
