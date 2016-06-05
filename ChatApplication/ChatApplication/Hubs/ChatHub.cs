using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace Signar2.Hubs
{
    public class ChatHub : Hub
    {
        private static int clientCounter = 0;

        
        public void Send(string name, string message)
        {
            Clients.All.addNewMessageToPage(name, message);
        }

        public override System.Threading.Tasks.Task OnConnected()
        {
            clientCounter++;
            Clients.All.recalculateOnlineUsers(clientCounter);
            return base.OnConnected();
        }

        public override System.Threading.Tasks.Task OnDisconnected(bool stopCalled)
        {
            clientCounter--;
            Clients.All.recalculateOnlineUsers(clientCounter);
            return base.OnDisconnected(stopCalled);
        }
    }
}