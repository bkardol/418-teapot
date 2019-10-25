using Microsoft.Extensions.DependencyInjection;
using Teapot.Controllers;

namespace Teapot.Extensions.DependencyInjection
{
    public static class MvcCoreMvcBuilderExtensions
    {
        public static void AddTeapot(this IMvcBuilder mvcBuilder)
        {
            mvcBuilder.AddApplicationPart(typeof(TeapotController).Assembly);
        }
    }
}
