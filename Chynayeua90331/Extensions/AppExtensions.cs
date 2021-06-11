using Chynayeua90331.Middleware;
using Microsoft.AspNetCore.Builder;

namespace Chynayeua90331.Extensions
{
    public static class AppExtensions
    {
        public static IApplicationBuilder UseFileLogging(this IApplicationBuilder app)
        => app.UseMiddleware<LogMiddleware>();
    }
}
