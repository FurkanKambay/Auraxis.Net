using System;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Util;

namespace Auraxis.Net.ConsoleApp
{
    internal class Program
    {
        //List<WorldStatHistory> result = await Auraxis.PC.Query<WorldStatHistory>()
        //    .Where(x => x.AllTime).IsGreaterThan(100)
        //    .Take(10)
        //    .GetAsync();
        //_ = result[0].DayValues;
        //var q = await Auraxis.PC.Query<Character>()
        //    .Where(c => c.Name.First).IsEqualTo("RedMuerte")
        //    .GetAsync();
        //var qAbility = Auraxis.PC.Query<Ability>();
        //var qMap = Auraxis.PC.Query<Map>(Server.Cobalt, Continent.Esamir, Continent.Indar);
        // .Where(p => p.TempValue.DayValues[08]).IsGreaterThan(0);
        //var r = await qMap.GetAsync();

        private static async Task Main()
        {
            //void OnLogin() { }
            //void OnLogout() { }

            //var a = EventStreaming.Log;
            //EventStreaming.PlayerLogin += OnLogin;
            //EventStreaming.PlayerLogout += OnLogout;
            //EventStreaming.PlayerLogin -= OnLogin;
            //EventStreaming.PlayerLogout -= OnLogout;

            var uri = new Uri("wss://push.planetside2.com/streaming?environment=ps2&service-id=s:example");
            var cts = new CancellationTokenSource();
            var socket = new ClientWebSocket();

            await socket.ConnectAsync(uri, cts.Token);
            Console.Write(socket.State);

            await Task.Factory.StartNew(
                cancellationToken: cts.Token,
                creationOptions: TaskCreationOptions.LongRunning,
                scheduler: TaskScheduler.Default,
                action: async () =>
                {
                    var bytes = new byte[128];
                    var buffer = new ArraySegment<byte>(bytes);

                    while (true)
                    {
                        WebSocketReceiveResult result = await socket.ReceiveAsync(buffer, cts.Token);
                        byte[] msgBytes = buffer.Skip(buffer.Offset).Take(result.Count).ToArray();
                        var rcvMsg = Encoding.UTF8.GetString(msgBytes);
                        Console.WriteLine("Received: {0}", rcvMsg);
                    }
                });

            while (true)
            {
                var input = Console.ReadLine();
                if (input == "CLOSE")
                {
                    cts.Cancel();
                    return;
                }

                var sendBytes = Encoding.UTF8.GetBytes(input);
                var sendBuffer = new ArraySegment<byte>(sendBytes);

                await socket.SendAsync(
                    buffer: sendBuffer,
                    messageType: WebSocketMessageType.Text,
                    endOfMessage: true,
                    cancellationToken: cts.Token);
            }
        }
    }
}
