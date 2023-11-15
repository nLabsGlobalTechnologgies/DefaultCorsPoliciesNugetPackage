# DefaultCorsPoliciesNugetPackage

# DefaultCorsPolicies NuGet Package

[![NuGet Version](https://img.shields.io/nuget/v/DefaultCorsPolicies.svg?style=flat)](https://www.nuget.org/packages/DefaultCorsPolicies/)

DefaultCorsPolicies, ASP.NET Core uygulamalarında varsayılan CORS politikalarını eklemek için kullanılan bir NuGet paketidir.

## Kurulum

NuGet Package Manager Console veya .NET CLI kullanarak paketi projenize ekleyin:

```bash
dotnet add package DefaultCorsPolicies
```

## Yada
```bash
Install-Package DefaultCorsPolicies
```
## Kullanımı
```
using Microsoft.Extensions.DependencyInjection;

namespace YourNamespace
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            // Diğer servis konfigürasyonları...

            // DefaultCorsPolicies eklendi
            services.AddDefaultCors();
        }

        // Diğer Startup metodları...
    }
}
```
## Örnek
```bash
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace YourNamespace.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SampleController : ControllerBase
    {
        private readonly ILogger<SampleController> _logger;

        public SampleController(ILogger<SampleController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok("DefaultCorsPolicies NuGet paketi kullanım örneği");
        }
    }
}

```
