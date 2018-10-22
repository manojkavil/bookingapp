using HappierLiving.Appointment.Service;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using System;
using System.Threading.Tasks;
using Xunit;

namespace HappierLiving.Appointment.ApiTest
{
    public class StudentControllerTest
    {
        private const string API_BASE_URL = "https://localhost:44394";
        [Fact]
        public async Task ShouldGetValue()
        {
            using (var testServer = CreateTestServer())
            {
                try
                {
                    var client = testServer.CreateClient();
                    var value = await client.GetAsync("api/values");
                  //  Assert.Equal("Hello world", value);
                }
                catch(Exception ex)
                {
                    var a = ex.Message;
                }
            }
        }
        private TestServer CreateTestServer()
        {
            try
            {
                var builder = new WebHostBuilder()
                .UseStartup<Startup>();
                return new TestServer(builder);
            }
            catch(Exception ex)
            {
                return null;
            }
        }

        [Fact]
        public async Task ShouldGetMockValue()
        {
            var serviceMock = new Mock<IStudentService>();
            serviceMock.Setup(m => m.DeleteStudent(1)).Returns(1);
            var serviceDescriptor = new ServiceDescriptor(typeof(IStudentService), serviceMock.Object);
            
           
            using(var testServer=new ConfigurableServer(s=>s.Remove(serviceDescriptor)))
            {
                var client = testServer.CreateClient();
                var value = await client.GetStringAsync("api/value");
                Assert.Equal("1", value);
            }
        }

    }
}
