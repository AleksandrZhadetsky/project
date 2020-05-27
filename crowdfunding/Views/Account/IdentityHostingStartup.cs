using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(crowdfunding.Areas.Identity.IdentityHostingStartup))]
namespace crowdfunding.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
            });
        }
    }
}