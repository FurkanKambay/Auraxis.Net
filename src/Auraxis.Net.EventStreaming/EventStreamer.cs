using System;
using System.Diagnostics;
using WebSocketSharp;

namespace Auraxis.Net.EventStreaming
{
    public class EventStreamer : IDisposable
    {
        public WebSocket Client { get; }

        public EventStreamer()
        {
            Client = new WebSocket("wss://push.planetside2.com/streaming?environment=ps2&service-id=s:example");
            Client.OnOpen += (sender, e) => Debug.WriteLine($"OnOpen");
            Client.OnMessage += (sender, e) => Debug.WriteLine($"OnMessage: {e.Data}");
            Client.OnError += (sender, e) => Debug.WriteLine($"OnError: {e.Message}");
            Client.OnClose += (sender, e) => Debug.WriteLine($"OnClose: {e.Reason}");
        }

        public void Connect() => Client.Connect();
        public void Send(string data) => Client.Send(data);
        public void Close() => Client.Close();

        void IDisposable.Dispose() => Close();
    }
}
