﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace crmvcsb
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                crmvcsb.Domain.NewOrder.NewOrderManager.ReInitialize();
                CreateWebHostBuilder(args).Build().Run();
            }
            catch (Exception e)
            {
                
            }
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
            .ConfigureLogging(logging => {
                logging.ClearProviders();
                logging.AddConsole();
                logging.AddDebug();
            })
            //http host for Fidler http test
            .UseUrls("http://localhost:5002")
            .UseStartup<Startup>();

    }
}
