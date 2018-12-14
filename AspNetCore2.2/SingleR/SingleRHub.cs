using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace AspNetCore2._2.SingleR
{
    public class SingleRHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            var aa = Context.ConnectionId;
            var aaa = Context.User;
            if (user.StartsWith('a'))
            {
                await Groups.AddToGroupAsync(aa, "A组");
            }
            await Clients.Group("A组").SendAsync("ReceiveMessage", user, message);
            //  await Clients.All.SendAsync("ReceiveMessage", user,message);
        }
    }
}
