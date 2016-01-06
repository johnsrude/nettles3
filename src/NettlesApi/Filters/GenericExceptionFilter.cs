using System.Net;
using System.Net.Http;
using System.Web.Http;
using Microsoft.AspNet.Mvc.Filters;


namespace NettlesApi.Filters
{
    public class GenericExceptionFilterAttribute : ExceptionFilterAttribute
    {
        public override void OnException(ExceptionContext context)
        {
            throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound));

        }
    }
}
