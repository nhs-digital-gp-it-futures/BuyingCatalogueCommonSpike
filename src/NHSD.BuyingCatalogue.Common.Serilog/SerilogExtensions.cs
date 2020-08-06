﻿using Microsoft.AspNetCore.Builder;
using Serilog;

namespace NHSD.BuyingCatalogue.Common.Serilog
{
    public static class SerilogExtensions
    {
        public static void ConfigureSerilog(this IApplicationBuilder app)
        {
            // adding test comment
            app.UseSerilogRequestLogging(opts =>
            {
                opts.GetLevel = SerilogRequestLoggingOptions.GetLevel;
            });
        }
    }
}