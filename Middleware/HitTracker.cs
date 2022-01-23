using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

using OktaDependencyInjection.Services.Interfaces;

namespace OktaDependencyInjection.Middleware
{
    public class HitTracker
    {
        private readonly RequestDelegate _next;
        private readonly INumberOfHitsService _numberOfHitsService;

        public HitTracker(RequestDelegate next, INumberOfHitsService numberOfHitsService)
        {
            _next = next;
            _numberOfHitsService = numberOfHitsService;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            _numberOfHitsService.NumberOfHits += 1;
            await _next(context);
        }
    }
}