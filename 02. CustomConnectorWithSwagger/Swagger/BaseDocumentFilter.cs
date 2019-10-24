using BasicCustomConnector.Swagger;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace customconnector.withswagger.Swagger
{
    public class BasePathDocumentFilter : IDocumentFilter
    {
        private readonly IOptions<SwaggerSettings> config;
        public BasePathDocumentFilter(IOptions<SwaggerSettings> config)
        {
            this.config = config;
        }
        public void Apply(OpenApiDocument swaggerDoc, DocumentFilterContext context)
        {
            swaggerDoc.Servers = new List<OpenApiServer>() { new OpenApiServer() { Url = this.config.Value.Host } };
        }
    }
}
