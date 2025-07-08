using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;
using Models;

namespace Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(ChatMessage message)
        {
            await Clients.User(message.ReceiverId)
                .SendAsync("ReceiveMessage", message);
        }
    }
} 