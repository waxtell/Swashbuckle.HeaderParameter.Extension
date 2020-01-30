# Swashbuckle.HeaderParameter.Extension
Decorate your controllers and methods with header parameters with this Swashbuckle extension

![Publish to nuget](https://github.com/waxtell/Swashbuckle.HeaderParameter.Extension/workflows/Publish%20to%20nuget/badge.svg?branch=master)

Adding support in your startup file:
```csharp
            services.AddSwaggerGen(c =>
            {
                c.AddHeaderParameters();
            });
```

Adding a required header parameter to a method:
```csharp
        [HttpPost]
        [HeaderParameter(Name = "Content-Type", Required = true, Example = "application/json")]
        public async Task<IActionResult> Post([FromBody] WeatherForecast _)
        {
```

Adding a header paramter to all methods within a controller:
```csharp
    [ApiController]
    [Route("[controller]")]
    [HeaderParameter(Name = "Content-Disposition", Required = true, Example = "inline")]
    public class WeatherForecastController : ControllerBase
    {
```