using Newtonsoft.Json;
using System.Net;

namespace APIEstatisticasStacks.Extensions
{
    public class ManipuladorExcecoesConfig
    {
        private readonly RequestDelegate next;

        public ManipuladorExcecoesConfig(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await next(context);
            }
            catch (Exception)
            {
                await HandleExceptionAsync(context);
            }
        }

        private Task HandleExceptionAsync(HttpContext context)
        {
            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

            var result = JsonConvert.SerializeObject("Houve uma falha no servidor. Por favor, tente novamente mais tarde.");
            context.Response.ContentType = "application/json";
            return context.Response.WriteAsync(result);
        }
    }
}