# Use-IWebHostEnvironment-In-Static-Class
with this method you can use IWebHostEnvironment in static class


use this refrences

```
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
```
```
next writh this method
public static IWebHostEnvironment WebEnv()
{
     var _accessor = new HttpContextAccessor();
     return _accessor.HttpContext.RequestServices.GetRequiredService<IWebHostEnvironment>();
}
```
thanks from
https://stackoverflow.com/questions/64482399/how-to-use-iwebhostenvironment-inside-static-class-in-asp-core
