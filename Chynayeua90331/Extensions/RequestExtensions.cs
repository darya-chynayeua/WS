using Microsoft.AspNetCore.Http;

namespace Chynayeua90331.Extensions
{
    public static class RequestExtensions
    {
        public static bool IsAjaxRequest(this HttpRequest request)
        {
            return request.Headers["x-requested-with"]
           .Equals("XMLHttpRequest");
        }
    }
}
