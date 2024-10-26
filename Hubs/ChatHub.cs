using Microsoft.AspNetCore.SignalR;

namespace Your_Graduation.Hubs
{
    public class ChatHub:Hub
    {
        public void NewMassage(string name, string massage)
        {
            //دي لو عاوز تبعت للكل 
            Clients.All.SendAsync("NewMassageNotfiay", name, massage);

        }

    }
}
