using System.Text;
namespace Misharp.Controls
{
    public class InviteApi
    {
        private Misharp.App _app;
        public InviteApi(Misharp.App app)
        {
            _app = app;
        }
        public class InviteCreateResponse
        {
            public string Code { get; set; }
            public override string ToString()
            {
                var sb = new StringBuilder();
                sb.Append("{\n");
                sb.Append($"  code: {this.Code}\n");
                sb.Append("}");
                return sb.ToString();
            }
        }
        public async Task<InviteCreateResponse> Create()
        {
            var result = await _app.Request<InviteCreateResponse>("invite/create", true);
            return result;
        }
        public async Task<List<object>> List(string sinceId, string untilId, int limit = 30)
        {
            var param = new Dictionary<string, object?>
            {
                { "limit", limit },
                { "sinceId", sinceId },
                { "untilId", untilId },
            };
            var result = await _app.Request<List<object>>("invite/list", param, true);
            return result;
        }
        public class InviteLimitResponse
        {
            public int? Remaining { get; set; }
            public override string ToString()
            {
                var sb = new StringBuilder();
                sb.Append("{\n");
                sb.Append($"  remaining: {this.Remaining}\n");
                sb.Append("}");
                return sb.ToString();
            }
        }
        public async Task<InviteLimitResponse> Limit()
        {
            var result = await _app.Request<InviteLimitResponse>("invite/limit", true);
            return result;
        }
    }
}