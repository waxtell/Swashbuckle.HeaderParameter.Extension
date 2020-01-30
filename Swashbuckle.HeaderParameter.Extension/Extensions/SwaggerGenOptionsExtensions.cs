using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.SwaggerGen;

// ReSharper disable once CheckNamespace
namespace Swashbuckle.HeaderParameter.Extension
{
    public static class SwaggerGenOptionsExtensions
    {
        public static void AddHeaderParameters(this SwaggerGenOptions swaggerGenOptions)
        {
            swaggerGenOptions.OperationFilter<HeaderParameterOperationalFilter>();
        }
    }
}
