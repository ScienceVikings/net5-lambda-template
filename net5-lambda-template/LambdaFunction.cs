using Amazon.Lambda.Core;
using Microsoft.Extensions.DependencyInjection;
using net5_lambda_template.Core;

[assembly:LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]
namespace net5_lambda_template
{
    public class LambdaFunction
    {
        public string Handler(string input)
        {
            var host = new LambdaHost(null);
            var services = host.HostBuilder.Build().Services;
            var app = services.GetService<LambdaApplication>();

            return app.DoTheJob(input);
        }
    }
}