using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace WebChat.Hubs
{
    [HubName("chatHub")]
    public class ChatHub : Hub
    {
        public void LetsChat(string Cl_Name, string Cl_Message)
        {
            Clients.All.NewMessage(Cl_Name, Cl_Message);
        }
    }
}