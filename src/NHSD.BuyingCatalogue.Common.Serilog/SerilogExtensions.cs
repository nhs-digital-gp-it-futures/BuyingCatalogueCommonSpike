using Microsoft.AspNetCore.Builder;
using Serilog;

namespace NHSD.BuyingCatalogue.Common.Serilog
{
    public static class SerilogExtensions
    {
        public static void ConfigureSerilog(this IApplicationBuilder app)
        {
            // should up to 2.0.1-something.2
            app.UseSerilogRequestLogging(opts =>
            {
                opts.GetLevel = SerilogRequestLoggingOptions.GetLevel;
            });
        }
    }
}