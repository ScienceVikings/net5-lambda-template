using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace net5_lambda_template.Core
{
    public class LambdaHost
    {
        public IHostBuilder HostBuilder => GetHostBuilder();
        
        private IHostBuilder _hostBuilder;
        private readonly string[] _hostArguments;
        
        public LambdaHost(string[] args)
        {
            _hostArguments = args;
        }

        private IHostBuilder GetHostBuilder()
        {
            if (_hostBuilder != null)
                return _hostBuilder;
            
            _hostBuilder = Host.CreateDefaultBuilder(_hostArguments)
                .ConfigureServices(ConfigureServicesInternal);

            return _hostBuilder;

        }
        
        private static void ConfigureServicesInternal(IServiceCollection services)
        {
            services.AddTransient<LambdaApplication>();
        }
    }
}