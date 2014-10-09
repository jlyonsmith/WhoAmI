using ServiceStack;
using ServiceStack.Logging;
using ServiceStack.Razor;
using Funq;
using System.Net;

namespace ﻿WhoAmIService
{
    public class AppHost : AppHostHttpListenerBase
    {

        public AppHost() : base("Who Am I", typeof(AppHost).Assembly)
        {
        }

        public override void Configure(Container container)
        {
            LogManager.LogFactory = new ConsoleLogFactory();

            Plugins.Add(new RazorFormat());

            this.CustomErrorHttpHandlers[HttpStatusCode.NotFound] = new RazorHandler("/notfound");
        }
    }
}