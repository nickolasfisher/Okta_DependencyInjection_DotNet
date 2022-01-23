using Okta.Sdk;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OktaDependencyInjection.Services.Interfaces
{
    public interface IOktaService
    {
        Task<List<User>> GetUsersAsync();
    }
}