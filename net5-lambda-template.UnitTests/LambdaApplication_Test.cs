using Microsoft.Extensions.DependencyInjection;
using net5_lambda_template.Core;
using NUnit.Framework;
using Shouldly;

namespace net5_lambda_template.UnitTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ShouldUpperCaseOurInput()
        {
            var host = new LambdaHost(null);
            var services = host.HostBuilder.Build().Services;
            var app = services.GetService<LambdaApplication>();
            
            var input = "hello testing";
            
            app.DoTheJob(input).ShouldBe(input.ToUpper());
        }
    }
}