using System.Collections.Generic;
using System.Linq;
using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using Swashbuckle.HeaderParameter.Extension.Extensions;

namespace Swashbuckle.HeaderParameter.Extension
{
    public class HeaderParameterOperationalFilter : IOperationFilter
    {
        private readonly ApiConfig _apiConfig;

        public HeaderParameterOperationalFilter(ApiConfig apiConfig)
        {
            _apiConfig = apiConfig;
        }

        public void Apply(OpenApiOperation operation, OperationFilterContext context)
        {
            if (operation.Parameters == null)
            {
                operation.Parameters = new List<OpenApiParameter>();
            }

            var parameterAttributes = context
                                        .GetControllerAndActionAttributes<HeaderParameterAttribute>()
                                        .ToList();

            var aggregatedHeaders = new List<IHeaderParameter>(_apiConfig.HeaderParameters);
            aggregatedHeaders.AddRange(parameterAttributes);

            foreach(var attr in aggregatedHeaders.Merge(x => x.Name))
            {
                operation
                    .Parameters
                    .Add
                    (
                        new OpenApiParameter
                        {
                            AllowEmptyValue = attr.AllowEmptyValue,
                            Deprecated = attr.Deprecated,
                            Description = attr.Description,
                            In = ParameterLocation.Header,
                            Name = attr.Name,
                            Required = attr.Required, 
                            Example = new OpenApiString(attr.Example ?? string.Empty),
                            AllowReserved = attr.AllowReserved,
                            Explode = attr.Explode,
                            Schema = string.IsNullOrWhiteSpace(attr.Type)
                                        ? null 
                                        : new OpenApiSchema { Type = attr.Type, Format = attr.Format }
                        }
                    );
            }
        }
    }
}
