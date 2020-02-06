using Microsoft.AspNetCore.Http;

namespace datingapp.api.helper
{
    public static class Extensions
    {
        public static void AddApplicationError(this HttpResponse response, string message)
        {
            response.Headers.Add("Application-Error", message);
            response.Headers.Add("Access-Control_Expose-Headers", "Application-Error");
            response.Headers.Add("Access-Control_Allow_Origin", "*");
        }
    }
}