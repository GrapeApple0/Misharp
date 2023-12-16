using System.Text;
namespace Misharp.Controls
{
    public class SwApi
    {
        private Misharp.App _app;
        public SwApi(Misharp.App app)
        {
            _app = app;
        }
        public class SwShowregistrationResponse
        {
            public string UserId { get; set; }
            public string Endpoint { get; set; }
            public bool SendReadMessage { get; set; }
            public override string ToString()
            {
                var sb = new StringBuilder();
                sb.Append("{\n");
                sb.Append($"  userId: {this.UserId}\n");
                sb.Append($"  endpoint: {this.Endpoint}\n");
                sb.Append($"  sendReadMessage: {this.SendReadMessage}\n");
                sb.Append("}");
                return sb.ToString();
            }
        }
        public async Task<SwShowregistrationResponse> Showregistration(string endpoint)
        {
            var param = new Dictionary<string, object?>
            {
                { "endpoint", endpoint },
            };
            var result = await _app.Request<SwShowregistrationResponse>("sw/show-registration", param, true);
            return result;
        }
        public class SwUpdateregistrationResponse
        {
            public string UserId { get; set; }
            public string Endpoint { get; set; }
            public bool SendReadMessage { get; set; }
            public override string ToString()
            {
                var sb = new StringBuilder();
                sb.Append("{\n");
                sb.Append($"  userId: {this.UserId}\n");
                sb.Append($"  endpoint: {this.Endpoint}\n");
                sb.Append($"  sendReadMessage: {this.SendReadMessage}\n");
                sb.Append("}");
                return sb.ToString();
            }
        }
        public async Task<SwUpdateregistrationResponse> Updateregistration(string endpoint, bool sendReadMessage)
        {
            var param = new Dictionary<string, object?>
            {
                { "endpoint", endpoint },
                { "sendReadMessage", sendReadMessage },
            };
            var result = await _app.Request<SwUpdateregistrationResponse>("sw/update-registration", param, true);
            return result;
        }
        public class SwRegisterResponse
        {
            public string State { get; set; }
            public string? Key { get; set; }
            public string UserId { get; set; }
            public string Endpoint { get; set; }
            public bool SendReadMessage { get; set; }
            public override string ToString()
            {
                var sb = new StringBuilder();
                sb.Append("{\n");
                sb.Append($"  state: {this.State}\n");
                sb.Append($"  key: {this.Key}\n");
                sb.Append($"  userId: {this.UserId}\n");
                sb.Append($"  endpoint: {this.Endpoint}\n");
                sb.Append($"  sendReadMessage: {this.SendReadMessage}\n");
                sb.Append("}");
                return sb.ToString();
            }
        }
        public async Task<SwRegisterResponse> Register(string endpoint, string auth, string publickey, bool sendReadMessage = false)
        {
            var param = new Dictionary<string, object?>
            {
                { "endpoint", endpoint },
                { "auth", auth },
                { "publickey", publickey },
                { "sendReadMessage", sendReadMessage },
            };
            var result = await _app.Request<SwRegisterResponse>("sw/register", param, true);
            return result;
        }
    }
}