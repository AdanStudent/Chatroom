// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Tree_Pt2;

namespace Microsoft.Azure.SignalR.Samples.ChatRoom
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Tree_Pt2.Program.Main2(args);
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
