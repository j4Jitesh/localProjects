using Microsoft.AspNetCore.Builder;

namespace WebApp.Wasm
{
    public static class WasmConfig
    {
        /// <summary>
        /// Map webassembly path.
        /// </summary>
        /// <param name="app"></param>
        public static void MapWasmRequestPath(this IApplicationBuilder app)
        {

            app.MapWhen(ctx => ctx.Request.Path.StartsWithSegments("/devexpress"), blazor =>
            {
                blazor.UseBlazorFrameworkFiles("/devexpress")
                .UseRouting()
                .UseEndpoints(endpoints =>
                {
                    endpoints.MapFallbackToController("Index", "Devexpress");
                });
            });
        }
    }
}
