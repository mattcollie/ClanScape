using System;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.Owin;

namespace ClanScape.Web.Api.Common.Helpers
{
    public class FixContentTypeHeader : OwinMiddleware
    {
        public FixContentTypeHeader(OwinMiddleware next) : base(next) { }

        public override async Task Invoke(IOwinContext context)
        {
            if (context == null) throw new ArgumentNullException("You must supply an Owin context object.");

            // Check here as requests can or cannot have Content-Type header
            if (!string.IsNullOrWhiteSpace(context.Request.ContentType))
            {
                MediaTypeHeaderValue contentType;

                if (!MediaTypeHeaderValue.TryParse(context.Request.ContentType, out contentType))
                {
                    context.Request.ContentType = context.Request.ContentType.TrimEnd(';');
                }
            }

            await Next.Invoke(context);
        }
    }
}