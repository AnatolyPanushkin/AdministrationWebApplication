using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace AdministrationWebApplication.Controllers
{
    [Controller]
    [Route("/health")]
    public class HealthCheckController : IHealthCheck
    {
        public Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            HttpClient client = new HttpClient();
            try
            {
                HttpResponseMessage responsePassenger = client.GetAsync("http://localhost:5000/api/passengers").Result;
                HttpResponseMessage responseTicket = client.GetAsync("http://localhost:5000/api/tickets").Result;
                if (responsePassenger.IsSuccessStatusCode && responseTicket.IsSuccessStatusCode)
                {
                    return Task.FromResult(
                        HealthCheckResult.Healthy("Service is alive"));
                }
            }
            catch (Exception e)
            {
            }
            return Task.FromResult(
                HealthCheckResult.Unhealthy("Service is dead"));
        }
    }
}