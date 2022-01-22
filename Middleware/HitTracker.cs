using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

using OktaDependencyInjection.Services.Interfaces;

namespace OktaDependencyInjection.Middleware
{
    public class HitTracker
    {
        private readonly RequestDelegate _next;

        public HitTracker(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context, INumberOfHitsService numberOfHitsService)
        {
            numberOfHitsService.NumberOfHits += 1;
            await _next(context);
        }
    }
}
