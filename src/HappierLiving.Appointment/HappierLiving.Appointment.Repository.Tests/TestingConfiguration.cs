using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace HappierLiving.Appointment.Repository.Tests
{
   public static class TestingConfiguration
    {
        public static IConfiguration Get()
        {
            IConfiguration config = new ConfigurationBuilder().AddJsonFile("appsettings_testing_config.json").Build();
            return config;
        }
    }
}
