using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(Projektuppgift_CSharp_ASP.NET.Areas.Identity.IdentityHostingStartup))]
namespace Projektuppgift_CSharp_ASP.NET.Areas.Identity
{
    using Microsoft.AspNetCore.Hosting;

    /// <summary>
    /// Defines the <see cref="IdentityHostingStartup" />.
    /// </summary>
    public class IdentityHostingStartup : IHostingStartup
    {
        /// <summary>
        /// The Configure.
        /// </summary>
        /// <param name="builder">The builder<see cref="IWebHostBuilder"/>.</param>
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) =>
            {
            });
        }
    }
}
