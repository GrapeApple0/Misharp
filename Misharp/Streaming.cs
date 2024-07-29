using System.Net.WebSockets;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace Misharp
{
    public class Streaming
    {

        public Streaming(App app)
        {
            _app = app;
        }

        private App _app;
        public async Task Stream()
        {
            ClientWebSocket ws = new ClientWebSocket();
            var uri = new Uri($"wss://{_app.Host}/streaming");
            var id = Guid.NewGuid().ToString();
            await ws.ConnectAsync(uri, CancellationToken.None);
            var buffer = new byte[1024];
            await Task.Delay(5000);
            var con = JsonSerializer.Serialize(new Dictionary<string, object>
                        {
                            { "type", "connect"},
                            { "body",
                                new Dictionary<string,string>{
                                    { "channel", "localTimeline" },
                                    { "id" , id }
                                }
                            }
                        });
            var connectMsg = Encoding.UTF8.GetBytes(con);
            await ws.SendAsync(new ArraySegment<byte>(connectMsg), WebSocketMessageType.Text, true, CancellationToken.None);

            MemoryStream ms = new MemoryStream();
            while (ws != null)
            {
                var result = await ws.ReceiveAsync(new ArraySegment<byte>(buffer), CancellationToken.None);
                ms.Write(buffer, 0, result.Count);
                if (result.EndOfMessage)
                {
                    var messageStr = Encoding.UTF8.GetString(ms.ToArray());
                    Console.WriteLine(JsonSerializer.Serialize(JsonSerializer.Deserialize<JsonNode>(messageStr)));
                    ms.Dispose();
                    ms = new MemoryStream();
                    if (messageStr != "")
                    {
                        var discon = JsonSerializer.Serialize(new Dictionary<string, object>
                        {
                            { "type", "disconnect"},
                            { "body",
                                new Dictionary<string,string>{
                                    { "id" , id }
                                }
                            }
                        });
                        var disconnectMsg = Encoding.UTF8.GetBytes(discon);
                        await ws.SendAsync(new ArraySegment<byte>(disconnectMsg), WebSocketMessageType.Text, true, CancellationToken.None);
                        await ws.CloseAsync(WebSocketCloseStatus.NormalClosure, string.Empty, CancellationToken.None);
                        break;
                    }
                }
            }
        }
    }
}
