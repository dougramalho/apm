using Elastic.Apm.SerilogEnricher;
using Elastic.CommonSchema.Serilog;
using Serilog;
using Serilog.Sinks.Elasticsearch;
using System.Reflection;
using Serilog.Exceptions;
using Serilog.Settings.Configuration;
//using Serilog.Sinks.Elasticsearch;

namespace ApmDemonstracao.Extensions
{
    public static class SerilogExtensions
    {
        public static void AddSerilog(IConfiguration configuration)
        {
            var environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
            //var configuration = new ConfigurationBuilder()
            //    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            //    .AddJsonFile(
            //        $"appsettings.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT")}.json",
            //        optional: true)
            //    .Build();

            Log.Logger = new LoggerConfiguration()
                .Enrich.FromLogContext()
                .Enrich.WithExceptionDetails()
                .WriteTo.Debug()
                .WriteTo.Console()
                .WriteTo.Elasticsearch(ConfigureElasticSink(configuration, environment))
                .Enrich.WithProperty("Environment", environment)
                .ReadFrom.Configuration(configuration)
                .CreateLogger();


            //Log.Logger = new LoggerConfiguration()
            //    .ReadFrom.Configuration(configuration)
            //    .Enrich.FromLogContext()
            //    .Enrich.WithMachineName()
            //    .Enrich.WithEnvironmentUserName()
            //    .Enrich.WithExceptionDetails()
            //    .Enrich.WithElasticApmCorrelationInfo()
            //    .Enrich.WithProperty("ApplicationName", $"API Elastic APM - {configuration.GetSection("DOTNET_ENVIRONMENT").Value}")
            //    .WriteTo.Elasticsearch(new ElasticsearchSinkOptions(new Uri(configuration["ElasticsearchSettings:uri"]))
            //    {
            //        CustomFormatter = new EcsTextFormatter(),
            //        AutoRegisterTemplate = true
            //    })
            //    .WriteTo.Console(outputTemplate: "")
            //    .CreateLogger();
        }

        static ElasticsearchSinkOptions ConfigureElasticSink(IConfiguration configuration, string environment)
        {
            return new ElasticsearchSinkOptions(new Uri(configuration["ElasticApm:ServerUrl"]))
            {
                AutoRegisterTemplate = true,
                IndexFormat = $"{Assembly.GetExecutingAssembly().GetName().Name.ToLower().Replace(".", "-")}-{environment?.ToLower().Replace(".", "-")}-{DateTime.UtcNow:yyyy-MM}"
            };
        }
    }
}
