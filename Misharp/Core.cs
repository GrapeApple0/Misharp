using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;

namespace Misharp;

public class Core
{
    public static async Task<object?> Request<T>(App app, string endpoint, Dictionary<string, object>? ps,
        bool useToken = false)
    {
        using var client = new HttpClient();
        var param = (from item in ps
                     where item.Value != null
                     select item).ToDictionary(item => item.Key, item => item.Value); ;

        if (useToken)
        {
            var i = new Dictionary<string, object>
            {
                { "i", app.Token }
            };
            param = param
                .Concat(i.Where(pair =>
                    !param.ContainsKey(pair.Key))
                ).ToDictionary(
                    pair => pair.Key,
                    pair => pair.Value
                );
        }

        var data = JsonSerializer.Serialize(param);
        var content = new StringContent(data, Encoding.UTF8, "application/json");
        var response = await client.PostAsync($"https://{app.Host}/api/{endpoint}", content);
        var resultContent = await response.Content.ReadAsStringAsync();

        JsonSerializerOptions options = new()
        {
            WriteIndented = true,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            Encoder = JavaScriptEncoder.Create(UnicodeRanges.All)
        };
        var result = JsonSerializer.Deserialize<T>(resultContent, options);
        if (result != null) return result;
        return null;
    }
}