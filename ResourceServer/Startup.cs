using Microsoft.AspNet.Builder;
using Microsoft.Framework.DependencyInjection;

namespace ResourceServer
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            app.UseServices(servicies => { servicies.AddMvc(); });
            app.UseMvc();
        }
    }
}
