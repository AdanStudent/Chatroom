// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using Microsoft.AspNetCore.SignalR;

namespace Microsoft.Azure.SignalR.Samples.ChatRoom
{
    public class Chat : Hub
    {
        public void BroadcastMessage(string name, string message)
        {
            Clients.All.SendAsync("broadcastMessage", name, string.Format("{0}, signed {1}", message, "please give us an A on my project please"));

            //Call 
            ParseMessage(message);
        }

        //public void BroadcastMessage(string message)
        //{
        //    Clients.All.SendAsync("broadcastMessage",  string.Format("{0}, signed {1}", message, "please give us an A on my project please"));


        //}

        public void ParseMessage(string message)
        {

        }

        public void Echo(string name, string message)
        {
            Clients.Client(Context.ConnectionId).SendAsync("echo", name, message + " (echo from server)");
        }
    }
}
