using Microsoft.AspNetCore.SignalR;

namespace BlazorChat.Server.Hubs
{
    public class TextHub : Hub
    {
        public async Task SendTextAsync(string text)
        {
            await Clients.All.SendAsync("ReceiveInformation", text);
        }
    }
}
