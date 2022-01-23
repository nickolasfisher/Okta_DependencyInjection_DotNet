using OktaDependencyInjection.Settings;
using Microsoft.Extensions.Options;
using Okta.Sdk;
using Okta.Sdk.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OktaDependencyInjection.Services
{
    public class OktaService : Interfaces.IOktaService
    {
        private OktaClient _client;

        public OktaService(IOptions<OktaConfiguration> options)
        {
            _client = new OktaClient(new OktaClientConfiguration()
            {
                OktaDomain = options.Value.Domain,
                Token = options.Value.Token
            });
        }

        public async Task<List<User>> GetUsersAsync()
        {
            var users = await _client.Users.ToListAsync();
            return users.Select(r => r as User).ToList();
        }
    }
}