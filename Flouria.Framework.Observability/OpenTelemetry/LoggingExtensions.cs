using JobHunter.Framework.Observability.OpenTelemetry;
using Serilog;
using Serilog.Configuration;

namespace Flouria.Framework.Observability.OpenTelemetry;

public static class LoggingExtensions
{
    public static LoggerConfiguration WithOpenTelemetryTraceId(this LoggerEnrichmentConfiguration enrichmentConfiguration)
    {
        if (enrichmentConfiguration == null) throw new ArgumentNullException(nameof(enrichmentConfiguration));
        return enrichmentConfiguration.With<OpenTelemetryTraceIdEnricher>();
    }
    
    public static LoggerConfiguration WithOpenTelemetrySpanId(this LoggerEnrichmentConfiguration enrichmentConfiguration)
    {
        if (enrichmentConfiguration == null) throw new ArgumentNullException(nameof(enrichmentConfiguration));
        return enrichmentConfiguration.With<OpenTelemetrySpanIdEnricher>();
    }
}