using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Use_IWebHostEnvironment_In_Static_Class.Models
{
    public static class StaticClass
    {
        public static IWebHostEnvironment WebEnv()
        {
            var _accessor = new HttpContextAccessor();
            return _accessor.HttpContext.RequestServices.GetRequiredService<IWebHostEnvironment>();
        }
    }
}
